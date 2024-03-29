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
	public partial class Category : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		public Category()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			Load_Category();
			Load_CategoryInfo();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
		void Load_CategoryInfo()
		{
			try
			{
				string commandLine = @"SELECT CategoryID AS '№',
                                    CategoryName AS 'Категория', CASE WHEN TypeCategory = 1 THEN 'Доход' WHEN TypeCategory = 0 THEN 'Расход' END AS 'Вид'
                                    FROM Category";
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
				dgvCategory.DataSource = table;

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
		private void btnAddCategory_Click(object sender, EventArgs e)
		{

			try
			{
				if (!string.IsNullOrEmpty(rtbAddCategory.Text) && cbTypeCategoryAdd.SelectedItem != null)
				{
					connection.Open();

					string CategoryName = rtbAddCategory.Text;
					string Type = cbTypeCategoryAdd.SelectedItem.ToString();
					bool TypeCategory;
					if (Type == "Доход")
					{
						TypeCategory = true;
					}
					else
					{
						TypeCategory = false;
					}

					string query = "INSERT INTO Category (CategoryName, TypeCategory) VALUES (@CategoryName, @TypeCategory)";
					SqlCommand cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
					cmd.Parameters.AddWithValue("@TypeCategory", TypeCategory);
					cmd.ExecuteNonQuery();
					MessageBox.Show(this, "Успешно добавлено");
					connection.Close();
					Load_CategoryInfo();

				}
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
		void Load_Category()
		{
			cbTypeCategoryAdd.Items.Add("Доход");
			cbTypeCategoryAdd.Items.Add("Расход");
		}

		private void bntDeleteCategory_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvCategory.Rows.Count > 0)
				{
					string CategoryID = (string)dgvCategory.SelectedRows[0].Cells[0].Value;
					connection.Open();
					string query = "DELETE FROM Category WHERE CategoryID = @CategoryID";
					SqlCommand checkCommand = new SqlCommand(query, connection);
					checkCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
					checkCommand.ExecuteNonQuery();
					connection.Close();
					Load_CategoryInfo(); 
				}
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
