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

namespace CourseProject
{
    public partial class Income : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public Income()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            Load_Category();
        }
        void Load_Category()
        {
            try
            {
                connection.Open();
                string query = @"SELECT CategoryName FROM Category WHERE TypeCategory = 'true'";
                SqlCommand cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbCategoryIncome.Items.Add(reader[0]);
                }
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

        private void btnCloseIncome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
				double Sum = Convert.ToDouble(rtbSumIncome.Text.Replace(".", ","));
				DateTime Date = dtpDataIncome.Value;
                string Comment = rtbCommentIncome.Text;

                string CategorySelect = cbCategoryIncome.SelectedItem.ToString();
                string commandCategory = $"SELECT CategoryID FROM Category WHERE CategoryName = '{CategorySelect}'";
                SqlCommand cmdCategory = new SqlCommand(commandCategory, connection);
                int Category = Convert.ToInt32(cmdCategory.ExecuteScalar());

                //string query = $"INSERT INTO Action (Category, Sum, Date, Comment) VALUES ({Category}, @Sum, @Date, @Comment)";
                string query = "INSERT INTO Action (Category, Sum, Date, Comment) VALUES (@Category, @Sum, @Date, @Comment)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Sum", Sum);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Comment", Comment);
                cmd.ExecuteNonQuery();
                MessageBox.Show(this, "Успешно добавлено");
				connection.Close();
				Close();
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
