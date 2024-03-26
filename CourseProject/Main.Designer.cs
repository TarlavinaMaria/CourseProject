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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIncome
            // 
            this.buttonIncome.Location = new System.Drawing.Point(25, 42);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(180, 40);
            this.buttonIncome.TabIndex = 0;
            this.buttonIncome.Text = "Доход";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // buttonExpense
            // 
            this.buttonExpense.Location = new System.Drawing.Point(639, 42);
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
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(25, 146);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(794, 354);
            this.dgvInfo.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(429, 42);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(180, 40);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // rtbSearch
            // 
            this.rtbSearch.Location = new System.Drawing.Point(25, 103);
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(794, 24);
            this.rtbSearch.TabIndex = 6;
            this.rtbSearch.Text = "Поиск";
            // 
            // rtbBalance
            // 
            this.rtbBalance.Location = new System.Drawing.Point(25, 12);
            this.rtbBalance.Name = "rtbBalance";
            this.rtbBalance.Size = new System.Drawing.Size(794, 24);
            this.rtbBalance.TabIndex = 2;
            this.rtbBalance.Text = "Баланс";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(227, 42);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 40);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Добавить категорию";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 512);
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
            this.Name = "Main";
            this.Text = "Учет доходов и расходов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonExpense;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.Windows.Forms.RichTextBox rtbBalance;
        private System.Windows.Forms.Button btnAddCategory;
    }
}

