namespace CourseProject
{
    partial class Income
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
			this.label1 = new System.Windows.Forms.Label();
			this.cbCategoryIncome = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbSumIncome = new System.Windows.Forms.RichTextBox();
			this.dtpDataIncome = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rtbCommentIncome = new System.Windows.Forms.RichTextBox();
			this.btnCloseIncome = new System.Windows.Forms.Button();
			this.btnAddIncome = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(21, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Категория:";
			// 
			// cbCategoryIncome
			// 
			this.cbCategoryIncome.FormattingEnabled = true;
			this.cbCategoryIncome.Location = new System.Drawing.Point(160, 21);
			this.cbCategoryIncome.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.cbCategoryIncome.Name = "cbCategoryIncome";
			this.cbCategoryIncome.Size = new System.Drawing.Size(333, 29);
			this.cbCategoryIncome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 79);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Сумма:";
			// 
			// rtbSumIncome
			// 
			this.rtbSumIncome.Location = new System.Drawing.Point(160, 76);
			this.rtbSumIncome.Margin = new System.Windows.Forms.Padding(4);
			this.rtbSumIncome.Name = "rtbSumIncome";
			this.rtbSumIncome.Size = new System.Drawing.Size(333, 39);
			this.rtbSumIncome.TabIndex = 3;
			this.rtbSumIncome.Text = "";
			// 
			// dtpDataIncome
			// 
			this.dtpDataIncome.Location = new System.Drawing.Point(160, 142);
			this.dtpDataIncome.Name = "dtpDataIncome";
			this.dtpDataIncome.Size = new System.Drawing.Size(333, 29);
			this.dtpDataIncome.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 148);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Дата:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Коментарии:";
			// 
			// rtbCommentIncome
			// 
			this.rtbCommentIncome.Location = new System.Drawing.Point(160, 188);
			this.rtbCommentIncome.Name = "rtbCommentIncome";
			this.rtbCommentIncome.Size = new System.Drawing.Size(333, 81);
			this.rtbCommentIncome.TabIndex = 12;
			this.rtbCommentIncome.Text = "";
			// 
			// btnCloseIncome
			// 
			this.btnCloseIncome.Location = new System.Drawing.Point(352, 285);
			this.btnCloseIncome.Name = "btnCloseIncome";
			this.btnCloseIncome.Size = new System.Drawing.Size(141, 41);
			this.btnCloseIncome.TabIndex = 11;
			this.btnCloseIncome.Text = "Закрыть";
			this.btnCloseIncome.UseVisualStyleBackColor = true;
			this.btnCloseIncome.Click += new System.EventHandler(this.btnCloseIncome_Click);
			// 
			// btnAddIncome
			// 
			this.btnAddIncome.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAddIncome.Location = new System.Drawing.Point(208, 285);
			this.btnAddIncome.Name = "btnAddIncome";
			this.btnAddIncome.Size = new System.Drawing.Size(127, 41);
			this.btnAddIncome.TabIndex = 10;
			this.btnAddIncome.Text = "Добавить";
			this.btnAddIncome.UseVisualStyleBackColor = true;
			this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
			// 
			// Income
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 344);
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
			this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.Name = "Income";
			this.Text = "Доходы";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoryIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbSumIncome;
        private System.Windows.Forms.DateTimePicker dtpDataIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbCommentIncome;
        private System.Windows.Forms.Button btnCloseIncome;
        private System.Windows.Forms.Button btnAddIncome;
    }
}