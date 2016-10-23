namespace FundManager.UserControls
{
	partial class SummaryUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbTitle = new System.Windows.Forms.GroupBox();
			this.tbTotalMarketValue = new System.Windows.Forms.TextBox();
			this.tbTotalStockWeight = new System.Windows.Forms.TextBox();
			this.tbTotalNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gbTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTitle
			// 
			this.gbTitle.Controls.Add(this.tbTotalMarketValue);
			this.gbTitle.Controls.Add(this.tbTotalStockWeight);
			this.gbTitle.Controls.Add(this.tbTotalNumber);
			this.gbTitle.Controls.Add(this.label3);
			this.gbTitle.Controls.Add(this.label2);
			this.gbTitle.Controls.Add(this.label1);
			this.gbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbTitle.Location = new System.Drawing.Point(0, 0);
			this.gbTitle.Name = "gbTitle";
			this.gbTitle.Size = new System.Drawing.Size(258, 108);
			this.gbTitle.TabIndex = 1;
			this.gbTitle.TabStop = false;
			this.gbTitle.Text = "Summary";
			// 
			// tbTotalMarketValue
			// 
			this.tbTotalMarketValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTotalMarketValue.BackColor = System.Drawing.SystemColors.Window;
			this.tbTotalMarketValue.Location = new System.Drawing.Point(129, 74);
			this.tbTotalMarketValue.Name = "tbTotalMarketValue";
			this.tbTotalMarketValue.ReadOnly = true;
			this.tbTotalMarketValue.Size = new System.Drawing.Size(116, 20);
			this.tbTotalMarketValue.TabIndex = 5;
			this.tbTotalMarketValue.TabStop = false;
			// 
			// tbTotalStockWeight
			// 
			this.tbTotalStockWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTotalStockWeight.BackColor = System.Drawing.SystemColors.Window;
			this.tbTotalStockWeight.Location = new System.Drawing.Point(129, 48);
			this.tbTotalStockWeight.Name = "tbTotalStockWeight";
			this.tbTotalStockWeight.ReadOnly = true;
			this.tbTotalStockWeight.Size = new System.Drawing.Size(116, 20);
			this.tbTotalStockWeight.TabIndex = 4;
			this.tbTotalStockWeight.TabStop = false;
			// 
			// tbTotalNumber
			// 
			this.tbTotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTotalNumber.BackColor = System.Drawing.SystemColors.Window;
			this.tbTotalNumber.Location = new System.Drawing.Point(129, 22);
			this.tbTotalNumber.Name = "tbTotalNumber";
			this.tbTotalNumber.ReadOnly = true;
			this.tbTotalNumber.Size = new System.Drawing.Size(116, 20);
			this.tbTotalNumber.TabIndex = 3;
			this.tbTotalNumber.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total Stock Weight";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Total Market Value";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total Number";
			// 
			// SummaryUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbTitle);
			this.Name = "SummaryUserControl";
			this.Size = new System.Drawing.Size(258, 108);
			this.gbTitle.ResumeLayout(false);
			this.gbTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbTitle;
		private System.Windows.Forms.TextBox tbTotalMarketValue;
		private System.Windows.Forms.TextBox tbTotalStockWeight;
		private System.Windows.Forms.TextBox tbTotalNumber;
	}
}
