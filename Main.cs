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
    public partial class Main : Form
    {
        private string connectionString;
        public Main()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }
        private bool login_check(string query) // перевірка на наявність запису
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

                    int h = 0;
                    h = Convert.ToInt32(inv.Rows[0][0]);

                    if (h == 1)
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
            catch (SqlException sqlExc)
            {
                MessageBox.Show(sqlExc.Message);
            }
            return false;
        }

        private int Selection_id(string query) // повернення вибраного айді з запису
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable inv = new DataTable();
                inv.Load(reader);
                int id = 0,passwordd=0;
                id = Convert.ToInt32(inv.Rows[0][0]);
                passwordd = Convert.ToInt32(inv.Rows[0][1]);

                if (passwordd.ToString() != password.Text)
                  {
                        MessageBox.Show("Неправильний пароль");
                        reader.Close();
                        connection.Close();
                        return 0;
                   }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                reader.Close();
                return Convert.ToInt32(id);
             } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = false;
            int id;
            if (login.Text != "" && password.Text != "")
            {
                // перевірка чи є введений логін у підприємствах
                string query = "SELECT COUNT(*) FROM Company WHERE [login] = '" + login.Text + "'";
                if (login_check(query))
                {
                    check = true;
                    // обрати айді підприємства
                    query = "SELECT id_company,[password] FROM Company WHERE [login] = '" + login.Text + "'";
                    id = Selection_id(query);
                    if (id != 0)
                    {
                        // та зайти у персональний кабінет
                        Employer c = new Employer(id);
                        c.Show();
                        return;
                    }
                }
                // перевірити чи є введений логін у претендентах
                query = "SELECT COUNT(*) AS D FROM Candidate WHERE [login] = '" + login.Text + "'";
                if (login_check(query))
                {
                    check = true;
                    // обрати айді претендента
                    query = "SELECT id_candidate,[password] FROM Candidate WHERE [login] = '" + login.Text + "'";
                    id = Selection_id(query);
                    if (id != 0)
                    { 
                        // та зайти у персональний кабінет
                        Candidate c = new Candidate(id);
                        c.Show();
                        return;
                    }
                }
                // перевірити чи є введений логін у працівниках агенції
                query = "SELECT COUNT(*) AS D FROM Worker WHERE [login] = '" + login.Text + "'";
                if (login_check(query))
                {
                    check = true;
                    // обрати айді працівника
                    query = "SELECT id_worker,[password] FROM Worker WHERE [login] = '" + login.Text + "'";
                    id = Selection_id(query);
                    if (id != 0)
                    {
                        // та зайти у персональний кабінет
                        Agency_worker c = new Agency_worker(id);
                        c.Show();
                        return;
                    }
                }
                if (!check)
                    MessageBox.Show("Користувача з таким логіном не існує");
            }
            else
                MessageBox.Show("Ви не ввели логін або пароль");
        }
        private void registration_Click(object sender, EventArgs e)
        {
            Registration f = new Registration();
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Кадрова агенція";
        }

        private void registration_Click_1(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }

        private void about_program_Click(object sender, EventArgs e)
        {
            AboutProgram f = new AboutProgram();
            f.Show();
        }
    }
}
