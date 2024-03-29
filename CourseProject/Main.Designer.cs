namespace CourseProject
{
    partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.buttonIncome = new System.Windows.Forms.Button();
			this.buttonExpense = new System.Windows.Forms.Button();
			this.dgvInfo = new System.Windows.Forms.DataGridView();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.rtbSearch = new System.Windows.Forms.RichTextBox();
			this.rtbBalance = new System.Windows.Forms.RichTextBox();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bntBasket = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonIncome
			// 
			this.buttonIncome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonIncome.Location = new System.Drawing.Point(17, 68);
			this.buttonIncome.Margin = new System.Windows.Forms.Padding(4);
			this.buttonIncome.Name = "buttonIncome";
			this.buttonIncome.Size = new System.Drawing.Size(168, 59);
			this.buttonIncome.TabIndex = 0;
			this.buttonIncome.Text = "Добавить доход";
			this.buttonIncome.UseVisualStyleBackColor = true;
			this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
			// 
			// buttonExpense
			// 
			this.buttonExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExpense.Location = new System.Drawing.Point(655, 68);
			this.buttonExpense.Margin = new System.Windows.Forms.Padding(4);
			this.buttonExpense.Name = "buttonExpense";
			this.buttonExpense.Size = new System.Drawing.Size(172, 59);
			this.buttonExpense.TabIndex = 1;
			this.buttonExpense.Text = "Добавить расход";
			this.buttonExpense.UseVisualStyleBackColor = true;
			this.buttonExpense.Click += new System.EventHandler(this.buttonExpense_Click);
			// 
			// dgvInfo
			// 
			this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInfo.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInfo.Location = new System.Drawing.Point(17, 204);
			this.dgvInfo.Margin = new System.Windows.Forms.Padding(4);
			this.dgvInfo.Name = "dgvInfo";
			this.dgvInfo.ReadOnly = true;
			this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInfo.Size = new System.Drawing.Size(810, 371);
			this.dgvInfo.TabIndex = 3;
			this.dgvInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellDoubleClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(378, 68);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(141, 59);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "Удалить запись";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// rtbSearch
			// 
			this.rtbSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbSearch.Location = new System.Drawing.Point(212, 140);
			this.rtbSearch.Margin = new System.Windows.Forms.Padding(4);
			this.rtbSearch.Name = "rtbSearch";
			this.rtbSearch.Size = new System.Drawing.Size(615, 46);
			this.rtbSearch.TabIndex = 6;
			this.rtbSearch.Text = "";
			this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
			// 
			// rtbBalance
			// 
			this.rtbBalance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbBalance.Location = new System.Drawing.Point(212, 18);
			this.rtbBalance.Margin = new System.Windows.Forms.Padding(4);
			this.rtbBalance.Name = "rtbBalance";
			this.rtbBalance.ReadOnly = true;
			this.rtbBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rtbBalance.Size = new System.Drawing.Size(615, 42);
			this.rtbBalance.TabIndex = 2;
			this.rtbBalance.Text = "";
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddCategory.Location = new System.Drawing.Point(193, 68);
			this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(177, 59);
			this.btnAddCategory.TabIndex = 7;
			this.btnAddCategory.Text = "Добавить категорию";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(17, 153);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Поиск по категориям:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(28, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 31);
			this.label2.TabIndex = 9;
			this.label2.Text = "Баланс:";
			// 
			// bntBasket
			// 
			this.bntBasket.Location = new System.Drawing.Point(526, 70);
			this.bntBasket.Name = "bntBasket";
			this.bntBasket.Size = new System.Drawing.Size(122, 57);
			this.bntBasket.TabIndex = 10;
			this.bntBasket.Text = "Корзина";
			this.bntBasket.UseVisualStyleBackColor = true;
			this.bntBasket.Click += new System.EventHandler(this.bntBasket_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 611);
			this.Controls.Add(this.bntBasket);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.rtbSearch);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.dgvInfo);
			this.Controls.Add(this.rtbBalance);
			this.Controls.Add(this.buttonExpense);
			this.Controls.Add(this.buttonIncome);
			this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.MaximumSize = new System.Drawing.Size(850, 650);
			this.MinimumSize = new System.Drawing.Size(850, 650);
			this.Name = "Main";
			this.Text = "Учет доходов и расходов";
			((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonExpense;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.Windows.Forms.RichTextBox rtbBalance;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bntBasket;
	}
}

