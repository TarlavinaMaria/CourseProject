using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseProject
{
    public partial class Main : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public Main()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public void LoadDirection()
        {
            
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            Income income= new Income();
            income.Show();
        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            Expense expense= new Expense();
            expense.Show();
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category= new Category();
            category.Show();
        }
    }
}
