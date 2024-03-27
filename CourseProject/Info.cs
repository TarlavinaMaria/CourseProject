﻿using System;
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
                    rtbCategoryInfo.Text = $"{reader[0]}";
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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
