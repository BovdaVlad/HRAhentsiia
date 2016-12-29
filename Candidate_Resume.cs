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
    public partial class Candidate_Resume : Form
    {
        private int id_candidate;
        private string connectionString;
        public Candidate_Resume(int id)
        {
            InitializeComponent();
            id_candidate = id;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
         }

        private void save_Click(object sender, EventArgs e)
        {
            if (skills.Text != String.Empty &&
                education.Text != String.Empty &&
                experience.Text != String.Empty &&
                foreign_language.Text != String.Empty &&
                phone.Text != String.Empty
                )
            {
                // оновити резюме кандидата
                string query = "UPDATE Blank (id_candidate, skills, education, experience, foreign_language, phone) " +
                    "VALUES (@id_candidate, @skills, @education, @experience, @foreign_language, @phone)  WHERE id_сandidate =" + id_candidate.ToString() + " ";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand c_updateBlank = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        c_updateBlank.Parameters.AddWithValue("@id_candidate", id_candidate);
                        c_updateBlank.Parameters.AddWithValue("@skills", skills.Text);
                        c_updateBlank.Parameters.AddWithValue("@education", education.Text);
                        c_updateBlank.Parameters.AddWithValue("@experience", experience.Text);
                        c_updateBlank.Parameters.AddWithValue("@foreign_language", foreign_language.Text);
                        c_updateBlank.Parameters.AddWithValue("@phone", phone.Text);

                        c_updateBlank.ExecuteScalar();

                    }
                }
                catch (SqlException sqlExc)
                {

                }
                MessageBox.Show("Дані оновлені");
                Close();
                
 
            }
            else
            {
                MessageBox.Show("Ви ввели не всі дані");
            }
        }

        private void Candidate_Resume_Load(object sender, EventArgs e)
        {
            this.Text = "Створення резюме";
        }
    }

    
}

