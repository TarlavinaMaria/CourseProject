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
	public partial class Basket : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		public Basket()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			LoadAction();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			try
			{
				string ActionID = (string)dgvBasket.SelectedRows[0].Cells[0].Value;
				if (dgvBasket.Rows.Count > 0)
				{
					connection.Open();

					string queryAdd = "INSERT INTO Action (Category, Sum, Date, Comment) SELECT Category, Sum, Date, Comment FROM Basket WHERE ActionID = @ActionID";
					SqlCommand checkCommandAdd = new SqlCommand(queryAdd, connection);
					checkCommandAdd.Parameters.AddWithValue("@ActionID", ActionID);
					checkCommandAdd.ExecuteNonQuery();

					string query = "DELETE FROM Basket WHERE ActionID = @ActionID";
					SqlCommand checkCommand = new SqlCommand(query, connection);
					checkCommand.Parameters.AddWithValue("@ActionID", ActionID);
					checkCommand.ExecuteNonQuery();
					connection.Close();
					LoadAction();

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
		public void LoadAction()
		{
			try
			{
				string commandLine = @"SELECT ActionID AS '№',
                                    CategoryName AS 'Категория', Sum AS 'Сумма', Date AS 'Дата', Comment AS 'Коментарии'
                                    FROM Basket, Category WHERE Category = CategoryID";
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
					row["Дата"] = Convert.ToDateTime(reader["Дата"]).ToString("dd.MM.yyyy");
				}
				dgvBasket.DataSource = table;
				dgvBasket.Columns[0].Visible = false;

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
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bntDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string ActionID = (string)dgvBasket.SelectedRows[0].Cells[0].Value;
				if (ActionID != null)
				{
					connection.Open();

					string query = "DELETE FROM Basket WHERE ActionID = @ActionID";
					SqlCommand checkCommand = new SqlCommand(query, connection);
					checkCommand.Parameters.AddWithValue("@ActionID", ActionID);
					checkCommand.ExecuteNonQuery();
					connection.Close();
					LoadAction();
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
