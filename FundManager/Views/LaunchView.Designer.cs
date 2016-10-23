namespace FundManager.Views
{
	partial class LaunchView
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
			FundManager.Models.SummaryModel summaryModel1 = new FundManager.Models.SummaryModel();
			FundManager.Models.SummaryModel summaryModel2 = new FundManager.Models.SummaryModel();
			FundManager.Models.SummaryModel summaryModel3 = new FundManager.Models.SummaryModel();
			this.dgvStocks = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lStockType = new System.Windows.Forms.Label();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.cbStockTypes = new System.Windows.Forms.ComboBox();
			this.nudQuantity = new System.Windows.Forms.NumericUpDown();
			this.lPrice = new System.Windows.Forms.Label();
			this.bAddStock = new System.Windows.Forms.Button();
			this.lQuantity = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.fundSummaryUserControl = new FundManager.UserControls.SummaryUserControl();
			this.bondSummaryUserControl = new FundManager.UserControls.SummaryUserControl();
			this.equitySummaryUserControl = new FundManager.UserControls.SummaryUserControl();
			((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvStocks
			// 
			this.dgvStocks.AllowUserToAddRows = false;
			this.dgvStocks.AllowUserToDeleteRows = false;
			this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStocks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStocks.Location = new System.Drawing.Point(0, 0);
			this.dgvStocks.Name = "dgvStocks";
			this.dgvStocks.ReadOnly = true;
			this.dgvStocks.Size = new System.Drawing.Size(820, 422);
			this.dgvStocks.TabIndex = 1;
			this.dgvStocks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStocks_CellFormatting);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(5);
			this.panel1.Size = new System.Drawing.Size(1047, 121);
			this.panel1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lStockType);
			this.groupBox1.Controls.Add(this.nudPrice);
			this.groupBox1.Controls.Add(this.cbStockTypes);
			this.groupBox1.Controls.Add(this.nudQuantity);
			this.groupBox1.Controls.Add(this.lPrice);
			this.groupBox1.Controls.Add(this.bAddStock);
			this.groupBox1.Controls.Add(this.lQuantity);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(5, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1037, 111);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adding new stock";
			// 
			// lStockType
			// 
			this.lStockType.AutoSize = true;
			this.lStockType.Location = new System.Drawing.Point(6, 27);
			this.lStockType.Name = "lStockType";
			this.lStockType.Size = new System.Drawing.Size(58, 13);
			this.lStockType.TabIndex = 3;
			this.lStockType.Text = "Stock type";
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(93, 76);
			this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(120, 20);
			this.nudPrice.TabIndex = 2;
			// 
			// cbStockTypes
			// 
			this.cbStockTypes.FormattingEnabled = true;
			this.cbStockTypes.Location = new System.Drawing.Point(93, 23);
			this.cbStockTypes.Name = "cbStockTypes";
			this.cbStockTypes.Size = new System.Drawing.Size(122, 21);
			this.cbStockTypes.TabIndex = 0;
			// 
			// nudQuantity
			// 
			this.nudQuantity.DecimalPlaces = 4;
			this.nudQuantity.Location = new System.Drawing.Point(93, 50);
			this.nudQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.Size = new System.Drawing.Size(120, 20);
			this.nudQuantity.TabIndex = 1;
			// 
			// lPrice
			// 
			this.lPrice.AutoSize = true;
			this.lPrice.Location = new System.Drawing.Point(6, 80);
			this.lPrice.Name = "lPrice";
			this.lPrice.Size = new System.Drawing.Size(31, 13);
			this.lPrice.TabIndex = 4;
			this.lPrice.Text = "Price";
			// 
			// bAddStock
			// 
			this.bAddStock.Location = new System.Drawing.Point(244, 75);
			this.bAddStock.Name = "bAddStock";
			this.bAddStock.Size = new System.Drawing.Size(75, 23);
			this.bAddStock.TabIndex = 3;
			this.bAddStock.Text = "Add Stock";
			this.bAddStock.UseVisualStyleBackColor = true;
			this.bAddStock.Click += new System.EventHandler(this.bAddStock_Click);
			// 
			// lQuantity
			// 
			this.lQuantity.AutoSize = true;
			this.lQuantity.Location = new System.Drawing.Point(6, 54);
			this.lQuantity.Name = "lQuantity";
			this.lQuantity.Size = new System.Drawing.Size(46, 13);
			this.lQuantity.TabIndex = 5;
			this.lQuantity.Text = "Quantity";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fundSummaryUserControl);
			this.panel2.Controls.Add(this.bondSummaryUserControl);
			this.panel2.Controls.Add(this.equitySummaryUserControl);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(820, 121);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(5);
			this.panel2.Size = new System.Drawing.Size(227, 422);
			this.panel2.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvStocks);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 121);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(820, 422);
			this.panel3.TabIndex = 4;
			// 
			// fundSummaryUserControl
			// 
			this.fundSummaryUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fundSummaryUserControl.Location = new System.Drawing.Point(5, 221);
			this.fundSummaryUserControl.Name = "fundSummaryUserControl";
			this.fundSummaryUserControl.Size = new System.Drawing.Size(217, 196);
			summaryModel1.TotalCount = new decimal(new int[] {
            0,
            0,
            0,
            0});
			summaryModel1.TotalMarketValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			summaryModel1.TotalStockWeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.fundSummaryUserControl.Summary = summaryModel1;
			this.fundSummaryUserControl.TabIndex = 2;
			this.fundSummaryUserControl.TabStop = false;
			this.fundSummaryUserControl.Title = "Fund summary";
			// 
			// bondSummaryUserControl
			// 
			this.bondSummaryUserControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.bondSummaryUserControl.Location = new System.Drawing.Point(5, 113);
			this.bondSummaryUserControl.Name = "bondSummaryUserControl";
			this.bondSummaryUserControl.Size = new System.Drawing.Size(217, 108);
			summaryModel2.TotalCount = new decimal(new int[] {
            0,
            0,
            0,
            0});
			summaryModel2.TotalMarketValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			summaryModel2.TotalStockWeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.bondSummaryUserControl.Summary = summaryModel2;
			this.bondSummaryUserControl.TabIndex = 1;
			this.bondSummaryUserControl.TabStop = false;
			this.bondSummaryUserControl.Title = "Bond summary";
			// 
			// equitySummaryUserControl
			// 
			this.equitySummaryUserControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.equitySummaryUserControl.Location = new System.Drawing.Point(5, 5);
			this.equitySummaryUserControl.Name = "equitySummaryUserControl";
			this.equitySummaryUserControl.Size = new System.Drawing.Size(217, 108);
			summaryModel3.TotalCount = new decimal(new int[] {
            0,
            0,
            0,
            0});
			summaryModel3.TotalMarketValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			summaryModel3.TotalStockWeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.equitySummaryUserControl.Summary = summaryModel3;
			this.equitySummaryUserControl.TabIndex = 0;
			this.equitySummaryUserControl.TabStop = false;
			this.equitySummaryUserControl.Title = "Equity summary";
			// 
			// LaunchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1047, 543);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "LaunchView";
			this.Text = "Fund manager";
			((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvStocks;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lQuantity;
		private System.Windows.Forms.Label lPrice;
		private System.Windows.Forms.Label lStockType;
		private System.Windows.Forms.ComboBox cbStockTypes;
		private System.Windows.Forms.Button bAddStock;
		private System.Windows.Forms.NumericUpDown nudPrice;
		private System.Windows.Forms.NumericUpDown nudQuantity;
		private System.Windows.Forms.GroupBox groupBox1;
		private UserControls.SummaryUserControl equitySummaryUserControl;
		private UserControls.SummaryUserControl bondSummaryUserControl;
		private UserControls.SummaryUserControl fundSummaryUserControl;
	}
}

