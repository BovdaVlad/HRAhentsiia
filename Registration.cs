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
using System.Configuration;

namespace HR_Ahentsiia
{
    public partial class Registration : Form
    {

        private string connectionString;
        public Registration()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.Text = "Реєстрація нового користувача";
            type.SelectedIndex = 0;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedIndex == 0)
            {
                name_company.Enabled = true;
                label11.Enabled = true;
               
            }
            else
            {
                name_company.Enabled = false;
                label11.Enabled = false;
            }
        }


        private bool login_check(string query)
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


        private void register_Click(object sender, EventArgs e)
        {
            if (name.Text != String.Empty &&
                surname.Text != String.Empty &&
                patronymic.Text != String.Empty &&
                password.Text != String.Empty &&
                password_repeat.Text != String.Empty &&
                email.Text != String.Empty &&
                login.Text != String.Empty

                )
            {
                if (password.Text == password_repeat.Text)
                {
                    if (type.SelectedIndex == 0) // якщо створюємо компанію
                    {
                        string query1 = "SELECT COUNT(*) FROM Company WHERE[login] = '" + login.Text + "'";
                        if (login_check(query1)) // перевірка чи існує вже кандидат з таким логіном
                        {
                            MessageBox.Show("Користувач з таким логіном вже зареєстрований");
                        }
                        else
                        {
                            if (name_company.Text != String.Empty)
                            {
                                // вставити нову компанію
                                string query = "INSERT INTO Company (name_company,email,login,password,name,surname,patronymic)" +
                                " VALUES (@name_company,@email,@login,@password,@name,@surname,@patronymic)";
                            try
                            {
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                using (SqlCommand c_insertCompany = new SqlCommand(query, connection))
                                {
                                    connection.Open();
                                    c_insertCompany.Parameters.AddWithValue("@name_company", name_company.Text);
                                    c_insertCompany.Parameters.AddWithValue("@email", email.Text);
                                    c_insertCompany.Parameters.AddWithValue("@login", login.Text);
                                    c_insertCompany.Parameters.AddWithValue("@password", password.Text);
                                    c_insertCompany.Parameters.AddWithValue("@name", name.Text);
                                    c_insertCompany.Parameters.AddWithValue("@surname", surname.Text);
                                    c_insertCompany.Parameters.AddWithValue("@patronymic", patronymic.Text);
                                    c_insertCompany.ExecuteScalar();
                                    connection.Close();
                                    MessageBox.Show("Користувач успішно доданий");
                                    Close();
                                        
                                     
                                    }
                            }
                            catch (SqlException sqlExc)
                            {
                                    MessageBox.Show(Convert.ToString(sqlExc.Message));
                            }
                            

                            }
                            else
                            {
                                MessageBox.Show("Введіть назву компанії");
                            }
                      
                        }
                    }
                    else // якщо створюємо кандидата
                    {
                       // перевірка наявнності такого логіну в кандидатах
                            string query1 = "SELECT COUNT(*) FROM Candidate WHERE[login] = '" + login.Text + "'";
                            if (login_check(query1))
                            {
                                MessageBox.Show("Користувач з таким логіном вже зареєстрований");
                            }
                            else
                            {
                            // вставка нового кандидата
                                string query = "INSERT INTO Candidate ([name],surname,patronymic,email,[login],[password]) " +
                                "VALUES (@[name],@surname,@patronymic,@email,@[login],@[password])";
                                try
                                {
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    using (SqlCommand c_insertCandidate = new SqlCommand(query, connection))
                                    {
                                        connection.Open();
                                        c_insertCandidate.Parameters.AddWithValue("@[name]", name.Text);
                                        c_insertCandidate.Parameters.AddWithValue("@surname", surname.Text);
                                        c_insertCandidate.Parameters.AddWithValue("@patronymic", patronymic.Text);
                                        c_insertCandidate.Parameters.AddWithValue("@email", email.Text);
                                        c_insertCandidate.Parameters.AddWithValue("@[login]", login.Text);
                                        c_insertCandidate.Parameters.AddWithValue("@[password]", password.Text);

                                        c_insertCandidate.ExecuteScalar();
                                        connection.Close();
                                        Close();

                                }
                                        MessageBox.Show("Користувач успішно доданий");
                                }
                                catch (SqlException sqlExc)
                                {

                                }
                               
                                MessageBox.Show("Користувач успішно доданий");
                                Close();
                        }
                      
                    }
                }
                else
                {
                    MessageBox.Show("Неправильний повтор пароля");
                }
            }
            else
                MessageBox.Show("Не всі дані введені");
        }

     
    }
}
