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
            this.rtbCategoryInfo = new System.Windows.Forms.RichTextBox();
            this.rtbSum = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbCategoryInfo
            // 
            this.rtbCategoryInfo.Location = new System.Drawing.Point(102, 10);
            this.rtbCategoryInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbCategoryInfo.Name = "rtbCategoryInfo";
            this.rtbCategoryInfo.Size = new System.Drawing.Size(201, 49);
            this.rtbCategoryInfo.TabIndex = 0;
            this.rtbCategoryInfo.Text = "";
            // 
            // rtbSum
            // 
            this.rtbSum.Location = new System.Drawing.Point(102, 77);
            this.rtbSum.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSum.Name = "rtbSum";
            this.rtbSum.Size = new System.Drawing.Size(201, 25);
            this.rtbSum.TabIndex = 1;
            this.rtbSum.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(102, 239);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(89, 29);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 239);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(102, 124);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(201, 22);
            this.dtpData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата:";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(102, 167);
            this.rtbComment.Margin = new System.Windows.Forms.Padding(2);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(201, 59);
            this.rtbComment.TabIndex = 8;
            this.rtbComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Коментарии:";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSum);
            this.Controls.Add(this.rtbCategoryInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Info";
            this.Text = "Информация о записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCategoryInfo;
        private System.Windows.Forms.RichTextBox rtbSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label label4;
    }
}