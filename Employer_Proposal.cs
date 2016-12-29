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
    public partial class Employer_Proposal : Form
    {

        private string connectionString;
        private int Id_employer;
        public Employer_Proposal(int id)
        {
            InitializeComponent();
            Id_employer = id;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void social_package_CheckedChanged(object sender, EventArgs e)
        {
            if (social_package.Checked)
                social_package.Text = "Надається";
            else
                social_package.Text = "Не надається";
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле заробітня платня не може містити букви");
            }

        }

        private void create_Click(object sender, EventArgs e)
        {
            // додати нову заяву
            string query = "INSERT INTO Vacancy (id_company,job_title,salary,requirements,responsibilities,social_package,work_schedule,section,city)"+
                           "VALUES (@id_company,@job_title,@salary,@requirements,@responsibilities,@social_package,@work_schedule,@section,@city)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_insertVacancy = new SqlCommand(query, connection))
                {
                    int sp=0;
                    if(social_package.Checked==true)
                    {
                        sp = 1;
                    }
                    connection.Open();
         
                    c_insertVacancy.Parameters.AddWithValue("@id_company", Id_employer);
                    c_insertVacancy.Parameters.AddWithValue("@job_title", job_title.Text);
                    c_insertVacancy.Parameters.AddWithValue("@salary", salary.Text);
                    c_insertVacancy.Parameters.AddWithValue("@requirements", requirements.Text);
                    c_insertVacancy.Parameters.AddWithValue("@responsibilities", responsibilities.Text);
                    c_insertVacancy.Parameters.AddWithValue("@social_package", sp);
                    c_insertVacancy.Parameters.AddWithValue("@work_schedul", work_schedule.Text);
                    c_insertVacancy.Parameters.AddWithValue("@section", section.Text);
                    c_insertVacancy.Parameters.AddWithValue("@city", city.Text);

                    c_insertVacancy.ExecuteNonQuery();

                }
            }
            catch (SqlException sqlExc)
            {

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
            MessageBox.Show("Заявка прийнята");
        }

        private void Employer_Proposal_Load(object sender, EventArgs e)
        {
            this.Text = "Створення заяви";
        }
    }
}
