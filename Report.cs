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
    public partial class Report : Form
    {
        private string connectionString;
        public Report()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HrAhentsiia.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.Text = "Звіт";
            menu.SelectedIndex = 0;
            Update_report("SELECT city,AVG(salary) AS [середня зарплата] FROM Vacancy GROUP BY city");
        }

        private void Update_report(string query) // оновлення таблиці
        {
            this.Text = "Звіт";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vacancy");
            data_report.DataSource = ds.Tables[0];
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            if(menu.SelectedIndex==0)
            {
                // групування по містах
                query = "SELECT city,AVG(salary) AS [середня зарплата]  FROM Vacancy GROUP BY city";
            }
            else if(menu.SelectedIndex==1)
            {
                // групування по підприємству
                query = "SELECT Company.name_company,X.[середня зарплата] FROM ( SELECT id_company, AVG(salary) AS[середня зарплата] FROM Vacancy GROUP BY id_company ) AS X JOIN Company ON Company.id_company = X.id_company ";
            }
            else
            {
                // групування по розділам
                query = "SELECT section,AVG(salary) AS [середня зарплата] FROM Vacancy GROUP BY section";
            }
            Update_report(query); // оновити таблицю
        }
    }
}
