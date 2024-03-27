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
			this.label4 = new System.Windows.Forms.Label();
			this.rtbCommentIncome = new System.Windows.Forms.RichTextBox();
			this.btnCloseIncome = new System.Windows.Forms.Button();
			this.btnAddIncome = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpDataIncome = new System.Windows.Forms.DateTimePicker();
			this.rtbSumIncome = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCategoryIncome = new System.Windows.Forms.ComboBox();
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
			// rtbCommentIncome
			// 
			this.rtbCommentIncome.Location = new System.Drawing.Point(148, 234);
			this.rtbCommentIncome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.rtbCommentIncome.Name = "rtbCommentIncome";
			this.rtbCommentIncome.Size = new System.Drawing.Size(376, 82);
			this.rtbCommentIncome.TabIndex = 22;
			this.rtbCommentIncome.Text = "";
			// 
			// btnCloseIncome
			// 
			this.btnCloseIncome.Location = new System.Drawing.Point(368, 328);
			this.btnCloseIncome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnCloseIncome.Name = "btnCloseIncome";
			this.btnCloseIncome.Size = new System.Drawing.Size(156, 43);
			this.btnCloseIncome.TabIndex = 21;
			this.btnCloseIncome.Text = "Закрыть";
			this.btnCloseIncome.UseVisualStyleBackColor = true;
			this.btnCloseIncome.Click += new System.EventHandler(this.btnCloseIncome_Click);
			// 
			// btnAddIncome
			// 
			this.btnAddIncome.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAddIncome.Location = new System.Drawing.Point(215, 328);
			this.btnAddIncome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnAddIncome.Name = "btnAddIncome";
			this.btnAddIncome.Size = new System.Drawing.Size(130, 43);
			this.btnAddIncome.TabIndex = 20;
			this.btnAddIncome.Text = "Добавить";
			this.btnAddIncome.UseVisualStyleBackColor = true;
			this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
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
			// dtpDataIncome
			// 
			this.dtpDataIncome.Location = new System.Drawing.Point(148, 172);
			this.dtpDataIncome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.dtpDataIncome.Name = "dtpDataIncome";
			this.dtpDataIncome.Size = new System.Drawing.Size(376, 29);
			this.dtpDataIncome.TabIndex = 18;
			// 
			// rtbSumIncome
			// 
			this.rtbSumIncome.Location = new System.Drawing.Point(148, 97);
			this.rtbSumIncome.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.rtbSumIncome.Name = "rtbSumIncome";
			this.rtbSumIncome.Size = new System.Drawing.Size(376, 42);
			this.rtbSumIncome.TabIndex = 17;
			this.rtbSumIncome.Text = "";
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
			// cbCategoryIncome
			// 
			this.cbCategoryIncome.FormattingEnabled = true;
			this.cbCategoryIncome.Location = new System.Drawing.Point(148, 35);
			this.cbCategoryIncome.Margin = new System.Windows.Forms.Padding(11, 7, 11, 7);
			this.cbCategoryIncome.Name = "cbCategoryIncome";
			this.cbCategoryIncome.Size = new System.Drawing.Size(376, 32);
			this.cbCategoryIncome.TabIndex = 15;
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
			this.ClientSize = new System.Drawing.Size(567, 427);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.rtbCommentIncome);
			this.Controls.Add(this.btnCloseIncome);
			this.Controls.Add(this.btnAddIncome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpDataIncome);
			this.Controls.Add(this.rtbSumIncome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbCategoryIncome);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Expense";
			this.Text = "Расходы";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtbCommentIncome;
		private System.Windows.Forms.Button btnCloseIncome;
		private System.Windows.Forms.Button btnAddIncome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpDataIncome;
		private System.Windows.Forms.RichTextBox rtbSumIncome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCategoryIncome;
		private System.Windows.Forms.Label label1;
	}
}