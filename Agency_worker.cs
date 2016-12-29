using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Ahentsiia
{
    public partial class Agency_worker : Form
    {
        private string connectionString;
        public Agency_worker(int id)
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void blankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Agency_worker_Load(object sender, EventArgs e)
        {
            this.Text = "Працівник кадрової агенції";
            // вивести вакансії
            string query = "SELECT id_vacancy,job_title,salary,section,city FROM Vacancy";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vacancy");
            list_vacancu.DataSource = ds.Tables[0];
            u();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void all_users_Click(object sender, EventArgs e)
        {
            All_users a = new All_users();
            a.Show();
        }
        private void u()
        {

            try
            {
                int id = Convert.ToInt32(list_vacancu.CurrentCell.Value.ToString());
                // вивести список претендентів на вибрану вакансію
                string sql = string.Format("SELECT C.id_candidate,C.name,C.surname,C.patronymic,C.email,Blank.skills,Blank.education,Blank.experience,Blank.phone FROM ( SELECT Candidate.id_candidate, Candidate.name, Candidate.surname, Candidate.patronymic, Candidate.email FROM Candidate WHERE id_candidate IN(SELECT id_candidate FROM Blank WHERE id_vacancy = {0})) AS C INNER JOIN Blank  ON Blank.id_candidate = C.id_candidate", id);
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();


                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                da.Fill(ds, "Blank");
                list_candidate.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Оберіть комірку з айді ");
            }
        }

        private void ResumeProcessing(int i)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                int id = Convert.ToInt32(list_vacancu.CurrentCell.Value.ToString());
                // змінити вибране резюме як затверджене або відкинуте
                string sql = string.Format("UPDATE Blank Set isaccepted = '{0}' Where id_vacancy = '{1}'", i, id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Резюме прийнято");
                    else
                        MessageBox.Show("Резюме не прийнято");
                }
            }
            catch (SqlException ex) { }
            catch (FormatException ex)
            {
                MessageBox.Show("Оберіть комірку з айді ");
            }
            catch (InvalidOperationException c)
            {
                MessageBox.Show(c.Message);
            }
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            ResumeProcessing(1);  
        }

        private void noconfirm_Click(object sender, EventArgs e)
        {
            ResumeProcessing(0);
        }

        private void list_vacancu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            u();
            // оновити вакансії
            string query = "SELECT id_vacancy,job_title,salary,section,city FROM Vacancy";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vacancy");
            list_vacancu.DataSource = ds.Tables[0];
        }
    }
}
