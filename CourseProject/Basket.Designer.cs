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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basket));
			this.dgvBasket = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.bntDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBasket
			// 
			this.dgvBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBasket.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBasket.Location = new System.Drawing.Point(22, 21);
			this.dgvBasket.Margin = new System.Windows.Forms.Padding(5);
			this.dgvBasket.MultiSelect = false;
			this.dgvBasket.Name = "dgvBasket";
			this.dgvBasket.ReadOnly = true;
			this.dgvBasket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBasket.Size = new System.Drawing.Size(574, 129);
			this.dgvBasket.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.Location = new System.Drawing.Point(425, 160);
			this.btnClose.Margin = new System.Windows.Forms.Padding(5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(153, 67);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnReturn.Location = new System.Drawing.Point(36, 160);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(5);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(153, 67);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// bntDelete
			// 
			this.bntDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntDelete.BackgroundImage")));
			this.bntDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bntDelete.Location = new System.Drawing.Point(239, 158);
			this.bntDelete.Name = "bntDelete";
			this.bntDelete.Size = new System.Drawing.Size(153, 67);
			this.bntDelete.TabIndex = 3;
			this.bntDelete.UseVisualStyleBackColor = true;
			this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
			// 
			// Basket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 241);
			this.Controls.Add(this.bntDelete);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvBasket);
			this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Basket";
			this.Text = "Корзина записи";
			((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBasket;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button bntDelete;
	}
}