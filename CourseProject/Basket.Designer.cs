namespace CourseProject
{
	partial class Basket
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
			this.dgvBasket = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBasket
			// 
			this.dgvBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBasket.Location = new System.Drawing.Point(24, 24);
			this.dgvBasket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.dgvBasket.MultiSelect = false;
			this.dgvBasket.Name = "dgvBasket";
			this.dgvBasket.ReadOnly = true;
			this.dgvBasket.Size = new System.Drawing.Size(941, 186);
			this.dgvBasket.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(617, 222);
			this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(348, 42);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnReturn.Location = new System.Drawing.Point(24, 222);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(348, 42);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Вернуть";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// Basket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 275);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvBasket);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Basket";
			this.Text = "Корзина записи";
			((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBasket;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnReturn;
	}
}