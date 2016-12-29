using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Ahentsiia
{
    public partial class Candidate : Form
    {
        private int id_candidate;
        private string connectionString;
        public Candidate(int id)
        {
            InitializeComponent();
            id_candidate = id;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void importance_salary_CheckedChanged(object sender, EventArgs e)
        {
            if (importance_salary.Checked)
                panel1.Enabled = false;
            else
                panel1.Enabled = true;
        }

        private void change_resume_Click(object sender, EventArgs e)
        {
            Candidate_Resume f = new Candidate_Resume(id_candidate);
            f.Show();
        }


        private bool check(string query) // перевірка наявності такого запису в таблиці
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable inv = new DataTable();
                inv.Load(reader);
                int count = 0;
                count = Convert.ToInt32(inv.Rows[0][0]);

                if (Convert.ToInt32(count) == 1)
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return false;
                }

            }
            
        }
        
        private void send_resume_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
           
            string query = "SELECT COUNT(*) FROM Blank WHERE id_candidate = " + id_candidate.ToString();
            if (check(query))  // перевірка наявності резюме кандидата
            {
                try
                {
                    connection.Open();
                    // обрати дані з резюме
                    query = "SELECT id_vacancy,id_candidate,skills,education,experience,[foreign_language],phone FROM Blank WHERE id_candidate = " + id_candidate.ToString();
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder cd = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Blank");
                    
                    int c = list_applications.SelectedCells[0].ColumnIndex;
                    if (c == 0)
                    {
                        // вставити нове резюме 
                        string sql = "INSERT INTO Blank " +
                            "(id_vacancy,id_candidate,skills,education,experience,foreign_language,phone,isaccepted) " +
                            "Values (@id_vacancy,@id_candidate,@skills,@education,@experience,@foreign_language,@phone,@isaccepted)";
                            int id_vacancy = Convert.ToInt32(list_applications.CurrentCell.Value.ToString());
                            using (SqlCommand cmd = new SqlCommand(sql, connection))
                            {
                                cmd.Parameters.AddWithValue("@id_vacancy", id_vacancy);
                                cmd.Parameters.AddWithValue("@id_candidate", id_candidate);
                                cmd.Parameters.AddWithValue("@skills", ds.Tables[0].Rows[0][0]);
                                cmd.Parameters.AddWithValue("@education", ds.Tables[0].Rows[0][1]);
                                cmd.Parameters.AddWithValue("@experience", ds.Tables[0].Rows[0][2]);
                                cmd.Parameters.AddWithValue("@foreign_language", ds.Tables[0].Rows[0][3]);
                                cmd.Parameters.AddWithValue("@phone", ds.Tables[0].Rows[0][4]);
                                cmd.Parameters.AddWithValue("@isaccepted", false);
                            cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Резюме відправлене");
                        }
                        else
                            MessageBox.Show("Оберіть комірку з айді ");
                    }
                    catch (SqlException ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                    catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
                
            }
            else
            {
                MessageBox.Show("Ви ще не створили резюме ");
            }
        }

        private void Message()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // вивести повідомлення про проходження першої співбесіди на дану вакансію
            string sql = string.Format("SELECT B.id_vacancy,job_title,salary,city FROM Vacancy INNER JOIN ( SELECT * FROM Blank WHERE Blank.isaccepted = 1  AND id_candidate={0}) AS B ON B.id_vacancy = Vacancy.id_vacancy",id_candidate);
            SqlDataAdapter da = new SqlDataAdapter(sql,connection);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vacancy");
            message.DataSource = ds.Tables[0];
        }

        private void Candidate_Load(object sender, EventArgs e)
        {
            this.Text = "Претендент";
            section.SelectedIndex = 0;
            city.SelectedIndex = 0;
            list_applications.MultiSelect = false;
            Message();
            // список всіх вакансій
            VacancySearch("SELECT id_vacancy,job_title,salary,section,city FROM Vacancy WHERE section= '" + Convert.ToString(section.SelectedItem) + "' AND city= '" + Convert.ToString(city.SelectedItem) + "'");
        }
        private void VacancySearch(string query)
        {
          
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable inv = new DataTable();
                    inv.Load(reader);
                    list_applications.DataSource = inv;
                    reader.Close();
                }
            }
            catch (SqlException sqlExc)
            {

            }
        }
        private void Update_Vacancy()
        {
            try
            {
                list_applications.Controls.Clear();
                string query;
                if (importance_salary.Checked == true) // список всіх вакансій
                    query = "SELECT id_vacancy,job_title,salary,section,city FROM Vacancy WHERE section= '" + Convert.ToString(section.SelectedItem) + "' AND city= '" + Convert.ToString(city.SelectedItem) + "'";
                else // список всіх вакансій
                    query = "SELECT id_vacancy,job_title,salary,section,city FROM Vacancy WHERE section='" + Convert.ToString(section.SelectedItem) + "' AND city= '" + Convert.ToString(city.SelectedItem) + "'" + " AND salary<=" + upper_limit.Value.ToString() + " AND salary>=" + lower_limit.Value.ToString();
                VacancySearch(query);
            }
            catch (SqlException sqlExc)
            {

            }
        }
        private void section_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Vacancy(); // оновити список всіх вакансій
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Vacancy(); // оновити список всіх вакансій
        }

        private void upper_limit_ValueChanged(object sender, EventArgs e)
        {
            Update_Vacancy(); // оновити список всіх вакансій
        }

      
    }
}
