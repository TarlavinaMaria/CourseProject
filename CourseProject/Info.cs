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
using System.IO;

namespace CourseProject
{
	public partial class Info : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		private string CellValue;
		public Info(string ActionID)
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			CellValue = ActionID;
			Load_Category(ActionID);
			Load_Sum(ActionID);
			Load_Data(ActionID);
			Load_Comment(ActionID);

		}
		void Load_Category(string ActionID)
		{
			try
			{
				connection.Open();
				string query = @"SELECT CategoryName FROM Action, Category WHERE Category = CategoryID AND ActionID = @ActionID";
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ActionID", ActionID);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					cbCategoryInfo.Text = $"{reader[0]}";
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
		void Load_Sum(string ActionID)
		{
			try
			{
				connection.Open();
				string query = @"SELECT Sum FROM Action WHERE ActionID = @ActionID";
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ActionID", ActionID);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					rtbSum.Text = $"{reader[0]}";
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
		void Load_Data(string ActionID)
		{
			try
			{
				connection.Open();
				string query = @"SELECT Date FROM Action WHERE ActionID = @ActionID";
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ActionID", ActionID);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					dtpData.Text = $"{reader[0]}";
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
		void Load_Comment(string ActionID)
		{
			try
			{
				connection.Open();
				string query = @"SELECT Comment FROM Action WHERE ActionID = @ActionID";
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ActionID", ActionID);
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					rtbComment.Text = $"{reader[0]}";
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

		private void btnChange_Click(object sender, EventArgs e)
		{
			Change(CellValue);
		}
		void Change(string ActionID)
		{
			try
			{
				connection.Open();
				
				double Sum = Convert.ToDouble(rtbSum.Text.Replace(".", ","));
				
				DateTime Date = dtpData.Value;
				string Comment = rtbComment.Text;

				string CategorySelect = cbCategoryInfo.SelectedItem.ToString();
				string commandCategory = $"SELECT CategoryID FROM Category WHERE CategoryName = '{CategorySelect}'";
				SqlCommand cmdCategory = new SqlCommand(commandCategory, connection);
				int Category = Convert.ToInt32(cmdCategory.ExecuteScalar());

				string query = $"UPDATE Action SET Category = @Category, Sum = @Sum, Date = @Date, Comment = @Comment WHERE ActionID = @ActionID";
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ActionID", ActionID);
				cmd.Parameters.AddWithValue("@Category", Category);
				cmd.Parameters.AddWithValue("@Sum", Sum);
				cmd.Parameters.AddWithValue("@Date", Date);
				cmd.Parameters.AddWithValue("@Comment", Comment);
				cmd.ExecuteNonQuery();
				MessageBox.Show(this, "Успешно изменено");
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
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbCategoryInfo_Click_1(object sender, EventArgs e)
		{
			try
			{
				//cbCategoryInfo.Items.Clear();

				string commandLine = @"SELECT CategoryName FROM Category";
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				connection.Open();
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					cbCategoryInfo.Items.Add(reader[0]);
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
	}
}
