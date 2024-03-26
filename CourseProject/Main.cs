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
            LoadAction();
            LoadBalance();
        }
        public void LoadBalance()
        {
            try
            {
                connection.Open();
                string commandLine = @"SELECT SUM(Sum) FROM Action";
                SqlCommand cmd = new SqlCommand(commandLine, connection);
                decimal sum = (decimal)cmd.ExecuteScalar();
                rtbBalance.Text = $"{sum}";
                rtbBalance.SelectionAlignment = HorizontalAlignment.Center;
                if (sum < 0) { rtbBalance.ForeColor = Color.Red; }
                else { rtbBalance.ForeColor = Color.Green; }
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (reader != null) reader.Close();
            }
        }
        public void LoadAction()
        {
            try
            {
                string commandLine = @"SELECT 
                                    CategoryName AS 'Категория', Sum AS 'Сумма', Date AS 'Дата', Comment AS 'Коментарии'
                                    FROM Action, Category WHERE Category = CategoryID";
                SqlCommand cmd = new SqlCommand(commandLine, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                table = new DataTable();
                for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                    table.Rows.Add(row);
                }
                dgvInfo.DataSource = table;

                reader.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (reader != null) reader.Close();
            }
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void rtbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = rtbSearch.Text;
                string query = "SELECT CategoryName AS 'Категория', Sum AS 'Сумма', Date AS 'Дата', Comment AS 'Коментарии' FROM Action JOIN Category ON Category = CategoryID WHERE CategoryName LIKE @searchText";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                connection.Open();
                reader = cmd.ExecuteReader();
                table = new DataTable();
                for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                    table.Rows.Add(row);
                }
                dgvInfo.DataSource = table;
                reader.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (reader != null) reader.Close();
            }
        }
    }
}
