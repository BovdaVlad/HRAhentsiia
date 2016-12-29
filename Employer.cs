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
    public partial class Employer : Form
    {
        private int Id_employer;
        private string connectionString;
        public Employer(int id)
        {
            InitializeComponent();
            Id_employer = id;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void new_statement_Click(object sender, EventArgs e)
        {
            Employer_Proposal f = new Employer_Proposal(Id_employer);
            f.Show();
        }

      
        private void Employer_Load(object sender, EventArgs e)
        {
            this.Text = "Роботодавець";
            my_statement.MultiSelect = false;
            candidates.MultiSelect = false;
            Update_table();
        }
        private void Update_table() // оновити список вакансій підприємства
        {

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_vacancy,job_title,salary,section,city FROM Vacancy WHERE id_company = " + Id_employer, connection);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "Vacancy");
                my_statement.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch(ArgumentException e)
            { }
        }
  
        private void my_statement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            { // виводимо список кандидатів які пройшли попередню співбесіду на вибрану вакансію
                int id = Convert.ToInt32(my_statement.CurrentCell.Value.ToString());
                string sql = string.Format("SELECT Candidate.name,Candidate.surname,Candidate.patronymic,Candidate.email FROM Candidate WHERE id_candidate IN (SELECT id_candidate FROM Blank WHERE isaccepted = 1 AND id_vacancy = {0} ) ", id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataTable qw = new DataTable();
                DA.Fill(qw);
                candidates.DataSource = qw;
            }
            catch (FormatException ex)
            { MessageBox.Show("Оберіть айді вакансії"); }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
