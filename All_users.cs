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
    public partial class All_users : Form
    {
        private string connectionString;
        public All_users()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }
        private void Download(string query, bool c) // завантажити таблицю 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            if (c)
            {
                da.Fill(ds, "Company");
                company.DataSource = ds.Tables[0];
            }
            else
            {
                da.Fill(ds, "Candidate");
                candidate.DataSource = ds.Tables[0];
            }
        }

        private void All_users_Load(object sender, EventArgs e)
        {
            candidate.MultiSelect = false;
            company.MultiSelect = false;
            // завантажити таблицю підприємств
            string query = "SELECT id_company,name_company,email,[name],surname,patronymic FROM Company";
            Download(query, true);
            // завантажити таблицю кандидатів
            query = "SELECT id_candidate,[name],surname,patronymic,email FROM Candidate";
            Download(query, false);
        }

        private void delete_company_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                int id = Convert.ToInt32(company.CurrentCell.Value.ToString());
                // видалити вакансії обраного підприємства
                string sql = string.Format("Delete FROM Vacancy WHERE id_company= {0}", id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                // видалити обране підприємство
                string sql1 = string.Format("Delete FROM Company WHERE id_company= {0}", id);
                using (SqlCommand cmd = new SqlCommand(sql1, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Exception error = new Exception("К сожалению, эта машина заказана!", ex);
                throw error;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Оберіть комірку з айді ");
            }
            connection.Close();
            // оновити таблицю
            string query = "SELECT id_company,name_company,email,[name],surname,patronymic FROM Company";
            Download(query, true);
        }

        private void delete_candidate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                int id = Convert.ToInt32(candidate.CurrentCell.Value.ToString());
                // видалити резюме кандидата
                string sql = string.Format("Delete FROM Blank WHERE id_candidate= {0}", id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                // видалити кандидата
                string sql1 = string.Format("Delete FROM Candidate WHERE id_candidate= {0}", id);
                using (SqlCommand cmd = new SqlCommand(sql1, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Exception error = new Exception("К сожалению, эта машина заказана!", ex);
                throw error;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Оберіть комірку з айді ");
            }
            connection.Close();
            // оновити таблицю
            string query = "SELECT id_candidate,[name],surname,patronymic,email FROM Candidate";
            Download(query, false);
        }


    }

}
