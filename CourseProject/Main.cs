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
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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

				string commandIncome = @"SELECT SUM(Sum) FROM Action WHERE Sum > 0";
				SqlCommand cmdIncome = new SqlCommand(commandIncome, connection);
				decimal sumIncome = (decimal)cmdIncome.ExecuteScalar();
				rtbIncome.Text = $"Доход всего: {sumIncome}";
				rtbIncome.SelectionAlignment = HorizontalAlignment.Center;
				rtbIncome.ForeColor = Color.Green;

				string commandExpense = @"SELECT SUM(Sum) FROM Action WHERE Sum < 0";
				SqlCommand cmdExpense = new SqlCommand(commandExpense, connection);
				decimal sumExpense = (decimal)cmdExpense.ExecuteScalar();
				rtbExpense.Text = $"Расход всего: {sumExpense}";
				rtbExpense.SelectionAlignment = HorizontalAlignment.Center;
				rtbExpense.ForeColor = Color.Red;



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

				string commandLine = @"SELECT ActionID AS '№',
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
					row["Дата"] = Convert.ToDateTime(reader["Дата"]).ToString("dd.MM.yyyy");
				}
				dgvInfo.DataSource = table;
				dgvInfo.Columns[0].Visible = false;

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
			DialogResult result = income.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				LoadAction();
				LoadBalance();
			}
		}

		private void buttonExpense_Click(object sender, EventArgs e)
		{
			Expense expense = new Expense();
			DialogResult result = expense.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				LoadAction();
				LoadBalance();
			}
		}


		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string ActionID = (string)dgvInfo.SelectedRows[0].Cells[0].Value;
				connection.Open();

				string queryAdd = "INSERT INTO Basket (Category, Sum, Date, Comment) SELECT Category, Sum, Date, Comment FROM Action WHERE ActionID = @ActionID";
				SqlCommand checkCommandAdd = new SqlCommand(queryAdd, connection);
				checkCommandAdd.Parameters.AddWithValue("@ActionID", ActionID);
				checkCommandAdd.ExecuteNonQuery();

				string query = "DELETE FROM Action WHERE ActionID = @ActionID";
				SqlCommand checkCommand = new SqlCommand(query, connection);
				checkCommand.Parameters.AddWithValue("@ActionID", ActionID);
				checkCommand.ExecuteNonQuery();
				connection.Close();
				LoadAction();
				LoadBalance();
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
			Category category = new Category();
			DialogResult result = category.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				LoadAction();
				LoadBalance();
			}
		}

		private void rtbSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string searchText = rtbSearch.Text;
				string query = "SELECT ActionID AS '№', CategoryName AS 'Категория', Sum AS 'Сумма', Date AS 'Дата', Comment AS 'Коментарии' FROM Action JOIN Category ON Category = CategoryID WHERE CategoryName LIKE @searchText";
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
					row["Дата"] = Convert.ToDateTime(reader["Дата"]).ToString("dd.MM.yyyy");
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

		private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string cellValue = dgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
				Info info = new Info(cellValue);
				DialogResult result = info.ShowDialog(this);
				if (result == DialogResult.OK)
				{
					LoadAction();
					LoadBalance();
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

		private void bntBasket_Click(object sender, EventArgs e)
		{
			Basket basket = new Basket();
			DialogResult result = basket.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				LoadAction();
				LoadBalance();
			}
		}

		private void btnSeachData_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime StartDate = dtpStartData.Value;
				DateTime StopDate = dtpStopData.Value;


				connection.Open();
				string commandLine = @"SELECT ActionID AS '№',
                                    CategoryName AS 'Категория', Sum AS 'Сумма', Date AS 'Дата', Comment AS 'Коментарии'
                                    FROM Action, Category WHERE Category = CategoryID AND Date BETWEEN @StartDate AND @StopDate";
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				cmd.Parameters.AddWithValue("@StartDate", StartDate);
				cmd.Parameters.AddWithValue("@StopDate", StopDate);
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
				dgvInfo.DataSource = table;
				dgvInfo.Columns[0].Visible = false;

				reader.Close();
				connection.Close();
				IncomeExpenseBalanse();

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
		void IncomeExpenseBalanse()
		{

			try
			{
				connection.Open();

				DateTime StartDate = dtpStartData.Value;
				DateTime StopDate = dtpStopData.Value;
				string commandBalanse = @"SELECT SUM(Sum) FROM Action WHERE Date BETWEEN @StartDate AND @StopDate";
				SqlCommand cmdBalanse = new SqlCommand(commandBalanse, connection);
				cmdBalanse.Parameters.AddWithValue("@StartDate", StartDate);
				cmdBalanse.Parameters.AddWithValue("@StopDate", StopDate);
				decimal sum = (decimal)cmdBalanse.ExecuteScalar();
				rtbBalance.Text = $"{sum}";
				rtbBalance.SelectionAlignment = HorizontalAlignment.Center;
				if (sum < 0) { rtbBalance.ForeColor = Color.Red; }
				else { rtbBalance.ForeColor = Color.Green; }

				string commandIncome = @"SELECT SUM(Sum) FROM Action WHERE Date BETWEEN @StartDate AND @StopDate AND Sum > 0";
				SqlCommand cmdIncome = new SqlCommand(commandIncome, connection);
				cmdIncome.Parameters.AddWithValue("@StartDate", StartDate);
				cmdIncome.Parameters.AddWithValue("@StopDate", StopDate);
				decimal sumIncome = (decimal)cmdIncome.ExecuteScalar();
				rtbIncome.Text = $"Доход за период: {sumIncome}";
				rtbIncome.SelectionAlignment = HorizontalAlignment.Center;
				rtbIncome.ForeColor = Color.Green;

				string commandExpense = @"SELECT SUM(Sum) FROM Action WHERE Date BETWEEN @StartDate AND @StopDate AND Sum < 0";
				SqlCommand cmdExpense = new SqlCommand(commandExpense, connection);
				cmdExpense.Parameters.AddWithValue("@StartDate", StartDate);
				cmdExpense.Parameters.AddWithValue("@StopDate", StopDate);
				decimal sumExpense = (decimal)cmdExpense.ExecuteScalar();
				rtbExpense.Text = $"Расход за период: {sumExpense}";
				rtbExpense.SelectionAlignment = HorizontalAlignment.Center;
				rtbExpense.ForeColor = Color.Red;

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
		private void btnReboot_Click(object sender, EventArgs e)
		{
			LoadAction();
			LoadBalance();
		}

		private void btnReport_Click(object sender, EventArgs e)
		{

		}
	}
}
