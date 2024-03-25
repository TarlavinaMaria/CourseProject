namespace CourseProject
{
    partial class Category
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.rtbAddCategory = new System.Windows.Forms.RichTextBox();
            this.cbTypeCategoryAdd = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(248, 96);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(220, 23);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Добавить категорию";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // rtbAddCategory
            // 
            this.rtbAddCategory.Location = new System.Drawing.Point(12, 12);
            this.rtbAddCategory.Name = "rtbAddCategory";
            this.rtbAddCategory.Size = new System.Drawing.Size(456, 51);
            this.rtbAddCategory.TabIndex = 1;
            this.rtbAddCategory.Text = "Введите название категории";
            // 
            // cbTypeCategoryAdd
            // 
            this.cbTypeCategoryAdd.FormattingEnabled = true;
            this.cbTypeCategoryAdd.Location = new System.Drawing.Point(12, 69);
            this.cbTypeCategoryAdd.Name = "cbTypeCategoryAdd";
            this.cbTypeCategoryAdd.Size = new System.Drawing.Size(456, 21);
            this.cbTypeCategoryAdd.TabIndex = 2;
            this.cbTypeCategoryAdd.Text = "Выберите тип";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 96);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 141);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbTypeCategoryAdd);
            this.Controls.Add(this.rtbAddCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "Category";
            this.Text = "Добавить категорию";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.RichTextBox rtbAddCategory;
        private System.Windows.Forms.ComboBox cbTypeCategoryAdd;
        private System.Windows.Forms.Button btnExit;
    }
}