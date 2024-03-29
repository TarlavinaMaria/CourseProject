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
			this.label3 = new System.Windows.Forms.Label();
			this.dtpStartData = new System.Windows.Forms.DateTimePicker();
			this.dtpStopData = new System.Windows.Forms.DateTimePicker();
			this.btnSeachData = new System.Windows.Forms.Button();
			this.btnReboot = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonIncome
			// 
			this.buttonIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIncome.BackgroundImage")));
			this.buttonIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonIncome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonIncome.Location = new System.Drawing.Point(17, 68);
			this.buttonIncome.Margin = new System.Windows.Forms.Padding(4);
			this.buttonIncome.Name = "buttonIncome";
			this.buttonIncome.Size = new System.Drawing.Size(154, 59);
			this.buttonIncome.TabIndex = 0;
			this.buttonIncome.UseVisualStyleBackColor = true;
			this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
			// 
			// buttonExpense
			// 
			this.buttonExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExpense.BackgroundImage")));
			this.buttonExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExpense.Location = new System.Drawing.Point(673, 68);
			this.buttonExpense.Margin = new System.Windows.Forms.Padding(4);
			this.buttonExpense.Name = "buttonExpense";
			this.buttonExpense.Size = new System.Drawing.Size(154, 59);
			this.buttonExpense.TabIndex = 1;
			this.buttonExpense.UseVisualStyleBackColor = true;
			this.buttonExpense.Click += new System.EventHandler(this.buttonExpense_Click);
			// 
			// dgvInfo
			// 
			this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvInfo.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInfo.Location = new System.Drawing.Point(17, 229);
			this.dgvInfo.Margin = new System.Windows.Forms.Padding(4);
			this.dgvInfo.MultiSelect = false;
			this.dgvInfo.Name = "dgvInfo";
			this.dgvInfo.ReadOnly = true;
			this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInfo.Size = new System.Drawing.Size(810, 369);
			this.dgvInfo.TabIndex = 3;
			this.dgvInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellDoubleClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
			this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(351, 67);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(154, 59);
			this.buttonDelete.TabIndex = 5;
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
			this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
			this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddCategory.Location = new System.Drawing.Point(179, 68);
			this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(154, 59);
			this.btnAddCategory.TabIndex = 7;
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
			this.bntBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntBasket.BackgroundImage")));
			this.bntBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bntBasket.Location = new System.Drawing.Point(512, 67);
			this.bntBasket.Name = "bntBasket";
			this.bntBasket.Size = new System.Drawing.Size(154, 59);
			this.bntBasket.TabIndex = 10;
			this.bntBasket.UseVisualStyleBackColor = true;
			this.bntBasket.Click += new System.EventHandler(this.bntBasket_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(17, 193);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 21);
			this.label3.TabIndex = 11;
			this.label3.Text = "Поиск по датам:";
			// 
			// dtpStartData
			// 
			this.dtpStartData.Location = new System.Drawing.Point(212, 193);
			this.dtpStartData.Name = "dtpStartData";
			this.dtpStartData.Size = new System.Drawing.Size(200, 29);
			this.dtpStartData.TabIndex = 12;
			this.dtpStartData.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
			// 
			// dtpStopData
			// 
			this.dtpStopData.Location = new System.Drawing.Point(430, 193);
			this.dtpStopData.Name = "dtpStopData";
			this.dtpStopData.Size = new System.Drawing.Size(200, 29);
			this.dtpStopData.TabIndex = 13;
			// 
			// btnSeachData
			// 
			this.btnSeachData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeachData.BackgroundImage")));
			this.btnSeachData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSeachData.Location = new System.Drawing.Point(646, 193);
			this.btnSeachData.Name = "btnSeachData";
			this.btnSeachData.Size = new System.Drawing.Size(77, 29);
			this.btnSeachData.TabIndex = 14;
			this.btnSeachData.UseVisualStyleBackColor = true;
			this.btnSeachData.Click += new System.EventHandler(this.btnSeachData_Click);
			// 
			// btnReboot
			// 
			this.btnReboot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReboot.BackgroundImage")));
			this.btnReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReboot.Location = new System.Drawing.Point(730, 193);
			this.btnReboot.Name = "btnReboot";
			this.btnReboot.Size = new System.Drawing.Size(92, 29);
			this.btnReboot.TabIndex = 15;
			this.btnReboot.UseVisualStyleBackColor = true;
			this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 611);
			this.Controls.Add(this.btnReboot);
			this.Controls.Add(this.btnSeachData);
			this.Controls.Add(this.dtpStopData);
			this.Controls.Add(this.dtpStartData);
			this.Controls.Add(this.label3);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(850, 650);
			this.MinimizeBox = false;
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpStartData;
		private System.Windows.Forms.DateTimePicker dtpStopData;
		private System.Windows.Forms.Button btnSeachData;
		private System.Windows.Forms.Button btnReboot;
	}
}

