namespace CourseProject
{
    partial class Expense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
			this.label4 = new System.Windows.Forms.Label();
			this.rtbCommentExpense = new System.Windows.Forms.RichTextBox();
			this.btnCloseExpense = new System.Windows.Forms.Button();
			this.btnAddExpense = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpDataExpense = new System.Windows.Forms.DateTimePicker();
			this.rtbSumExpense = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCategoryExpense = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 264);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "Коментарии:";
			// 
			// rtbCommentExpense
			// 
			this.rtbCommentExpense.Location = new System.Drawing.Point(148, 234);
			this.rtbCommentExpense.Margin = new System.Windows.Forms.Padding(6);
			this.rtbCommentExpense.Name = "rtbCommentExpense";
			this.rtbCommentExpense.Size = new System.Drawing.Size(376, 82);
			this.rtbCommentExpense.TabIndex = 22;
			this.rtbCommentExpense.Text = "";
			// 
			// btnCloseExpense
			// 
			this.btnCloseExpense.Location = new System.Drawing.Point(368, 328);
			this.btnCloseExpense.Margin = new System.Windows.Forms.Padding(6);
			this.btnCloseExpense.Name = "btnCloseExpense";
			this.btnCloseExpense.Size = new System.Drawing.Size(156, 43);
			this.btnCloseExpense.TabIndex = 21;
			this.btnCloseExpense.Text = "Закрыть";
			this.btnCloseExpense.UseVisualStyleBackColor = true;
			this.btnCloseExpense.Click += new System.EventHandler(this.btnCloseExpense_Click);
			// 
			// btnAddExpense
			// 
			this.btnAddExpense.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAddExpense.Location = new System.Drawing.Point(215, 328);
			this.btnAddExpense.Margin = new System.Windows.Forms.Padding(6);
			this.btnAddExpense.Name = "btnAddExpense";
			this.btnAddExpense.Size = new System.Drawing.Size(130, 43);
			this.btnAddExpense.TabIndex = 20;
			this.btnAddExpense.Text = "Добавить";
			this.btnAddExpense.UseVisualStyleBackColor = true;
			this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 177);
			this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 24);
			this.label3.TabIndex = 19;
			this.label3.Text = "Дата:";
			// 
			// dtpDataExpense
			// 
			this.dtpDataExpense.Location = new System.Drawing.Point(148, 172);
			this.dtpDataExpense.Margin = new System.Windows.Forms.Padding(6);
			this.dtpDataExpense.Name = "dtpDataExpense";
			this.dtpDataExpense.Size = new System.Drawing.Size(376, 29);
			this.dtpDataExpense.TabIndex = 18;
			// 
			// rtbSumExpense
			// 
			this.rtbSumExpense.Location = new System.Drawing.Point(148, 97);
			this.rtbSumExpense.Margin = new System.Windows.Forms.Padding(7);
			this.rtbSumExpense.Name = "rtbSumExpense";
			this.rtbSumExpense.Size = new System.Drawing.Size(376, 42);
			this.rtbSumExpense.TabIndex = 17;
			this.rtbSumExpense.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 100);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "Сумма:";
			// 
			// cbCategoryExpense
			// 
			this.cbCategoryExpense.FormattingEnabled = true;
			this.cbCategoryExpense.Location = new System.Drawing.Point(148, 35);
			this.cbCategoryExpense.Margin = new System.Windows.Forms.Padding(11, 7, 11, 7);
			this.cbCategoryExpense.Name = "cbCategoryExpense";
			this.cbCategoryExpense.Size = new System.Drawing.Size(376, 32);
			this.cbCategoryExpense.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(20, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 21);
			this.label1.TabIndex = 14;
			this.label1.Text = "Категория:";
			// 
			// Expense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 385);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.rtbCommentExpense);
			this.Controls.Add(this.btnCloseExpense);
			this.Controls.Add(this.btnAddExpense);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpDataExpense);
			this.Controls.Add(this.rtbSumExpense);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbCategoryExpense);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Expense";
			this.Text = "Расходы";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtbCommentExpense;
		private System.Windows.Forms.Button btnCloseExpense;
		private System.Windows.Forms.Button btnAddExpense;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpDataExpense;
		private System.Windows.Forms.RichTextBox rtbSumExpense;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCategoryExpense;
		private System.Windows.Forms.Label label1;
	}
}