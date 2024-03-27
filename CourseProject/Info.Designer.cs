namespace CourseProject
{
    partial class Info
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
            this.rtbSum = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoryInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbSum
            // 
            this.rtbSum.Location = new System.Drawing.Point(146, 80);
            this.rtbSum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbSum.Name = "rtbSum";
            this.rtbSum.Size = new System.Drawing.Size(285, 33);
            this.rtbSum.TabIndex = 1;
            this.rtbSum.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(145, 266);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(127, 41);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 41);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(146, 122);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(285, 29);
            this.dtpData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата:";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(145, 169);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(285, 81);
            this.rtbComment.TabIndex = 8;
            this.rtbComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Коментарии:";
            // 
            // cbCategoryInfo
            // 
            this.cbCategoryInfo.FormattingEnabled = true;
            this.cbCategoryInfo.Location = new System.Drawing.Point(146, 31);
            this.cbCategoryInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoryInfo.Name = "cbCategoryInfo";
            this.cbCategoryInfo.Size = new System.Drawing.Size(284, 29);
            this.cbCategoryInfo.TabIndex = 10;
            this.cbCategoryInfo.Click += new System.EventHandler(this.cbCategoryInfo_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 323);
            this.Controls.Add(this.cbCategoryInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSum);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Info";
            this.Text = "Информация о записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoryInfo;
    }
}