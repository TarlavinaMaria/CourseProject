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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.rtbAddCategory = new System.Windows.Forms.RichTextBox();
			this.cbTypeCategoryAdd = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.dgvCategory = new System.Windows.Forms.DataGridView();
			this.bntDeleteCategory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Location = new System.Drawing.Point(20, 155);
			this.btnAddCategory.Margin = new System.Windows.Forms.Padding(5);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(193, 37);
			this.btnAddCategory.TabIndex = 0;
			this.btnAddCategory.Text = "Добавить категорию";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// rtbAddCategory
			// 
			this.rtbAddCategory.Location = new System.Drawing.Point(200, 19);
			this.rtbAddCategory.Margin = new System.Windows.Forms.Padding(5);
			this.rtbAddCategory.Name = "rtbAddCategory";
			this.rtbAddCategory.Size = new System.Drawing.Size(397, 80);
			this.rtbAddCategory.TabIndex = 1;
			this.rtbAddCategory.Text = "";
			// 
			// cbTypeCategoryAdd
			// 
			this.cbTypeCategoryAdd.FormattingEnabled = true;
			this.cbTypeCategoryAdd.Location = new System.Drawing.Point(200, 111);
			this.cbTypeCategoryAdd.Margin = new System.Windows.Forms.Padding(5);
			this.cbTypeCategoryAdd.Name = "cbTypeCategoryAdd";
			this.cbTypeCategoryAdd.Size = new System.Drawing.Size(397, 29);
			this.cbTypeCategoryAdd.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(419, 155);
			this.btnExit.Margin = new System.Windows.Forms.Padding(5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(178, 37);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Закрыть";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dgvCategory
			// 
			this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategory.Location = new System.Drawing.Point(14, 202);
			this.dgvCategory.Margin = new System.Windows.Forms.Padding(5);
			this.dgvCategory.MultiSelect = false;
			this.dgvCategory.Name = "dgvCategory";
			this.dgvCategory.ReadOnly = true;
			this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategory.Size = new System.Drawing.Size(583, 303);
			this.dgvCategory.TabIndex = 4;
			// 
			// bntDeleteCategory
			// 
			this.bntDeleteCategory.Location = new System.Drawing.Point(223, 155);
			this.bntDeleteCategory.Margin = new System.Windows.Forms.Padding(5);
			this.bntDeleteCategory.Name = "bntDeleteCategory";
			this.bntDeleteCategory.Size = new System.Drawing.Size(176, 37);
			this.bntDeleteCategory.TabIndex = 5;
			this.bntDeleteCategory.Text = "Удалить";
			this.bntDeleteCategory.UseVisualStyleBackColor = true;
			this.bntDeleteCategory.Click += new System.EventHandler(this.bntDeleteCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Введите название:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 114);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "Выберите тип:";
			// 
			// Category
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 536);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bntDeleteCategory);
			this.Controls.Add(this.dgvCategory);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.cbTypeCategoryAdd);
			this.Controls.Add(this.rtbAddCategory);
			this.Controls.Add(this.btnAddCategory);
			this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Category";
			this.Text = "Добавить категорию";
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.RichTextBox rtbAddCategory;
        private System.Windows.Forms.ComboBox cbTypeCategoryAdd;
        private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridView dgvCategory;
		private System.Windows.Forms.Button bntDeleteCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}