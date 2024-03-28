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
			((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonIncome
			// 
			this.buttonIncome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonIncome.Location = new System.Drawing.Point(16, 52);
			this.buttonIncome.Name = "buttonIncome";
			this.buttonIncome.Size = new System.Drawing.Size(180, 40);
			this.buttonIncome.TabIndex = 0;
			this.buttonIncome.Text = "Доход";
			this.buttonIncome.UseVisualStyleBackColor = true;
			this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
			// 
			// buttonExpense
			// 
			this.buttonExpense.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExpense.Location = new System.Drawing.Point(639, 52);
			this.buttonExpense.Name = "buttonExpense";
			this.buttonExpense.Size = new System.Drawing.Size(180, 40);
			this.buttonExpense.TabIndex = 1;
			this.buttonExpense.Text = "Расход";
			this.buttonExpense.UseVisualStyleBackColor = true;
			this.buttonExpense.Click += new System.EventHandler(this.buttonExpense_Click);
			// 
			// dgvInfo
			// 
			this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInfo.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInfo.Location = new System.Drawing.Point(12, 146);
			this.dgvInfo.MultiSelect = false;
			this.dgvInfo.Name = "dgvInfo";
			this.dgvInfo.ReadOnly = true;
			this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInfo.Size = new System.Drawing.Size(807, 403);
			this.dgvInfo.TabIndex = 3;
			this.dgvInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellDoubleClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(432, 52);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(180, 40);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// rtbSearch
			// 
			this.rtbSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbSearch.Location = new System.Drawing.Point(217, 106);
			this.rtbSearch.Name = "rtbSearch";
			this.rtbSearch.Size = new System.Drawing.Size(602, 34);
			this.rtbSearch.TabIndex = 6;
			this.rtbSearch.Text = "";
			this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
			// 
			// rtbBalance
			// 
			this.rtbBalance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbBalance.Location = new System.Drawing.Point(101, 15);
			this.rtbBalance.Name = "rtbBalance";
			this.rtbBalance.ReadOnly = true;
			this.rtbBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rtbBalance.Size = new System.Drawing.Size(718, 31);
			this.rtbBalance.TabIndex = 2;
			this.rtbBalance.Text = "";
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddCategory.Location = new System.Drawing.Point(217, 52);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(196, 40);
			this.btnAddCategory.TabIndex = 7;
			this.btnAddCategory.Text = "Добавить категорию";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Поиск по категориям:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 21);
			this.label2.TabIndex = 9;
			this.label2.Text = "Баланс:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 561);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.rtbSearch);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.dgvInfo);
			this.Controls.Add(this.rtbBalance);
			this.Controls.Add(this.buttonExpense);
			this.Controls.Add(this.buttonIncome);
			this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximumSize = new System.Drawing.Size(847, 600);
			this.MinimumSize = new System.Drawing.Size(847, 600);
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
    }
}

