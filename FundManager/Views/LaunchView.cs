using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FundManager.Models;
using WinFormsMvp.Forms;

namespace FundManager.Views
{
	public partial class LaunchView : MvpForm<LaunchModel>, ILaunchView
	{

		public LaunchView()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			
			cbStockTypes.DataSource = new BindingSource(Model.StockTypes, null);
			nudQuantity.DataBindings.Add(new Binding("Value", Model.NewStock, "Quantity", false, DataSourceUpdateMode.OnPropertyChanged));
			nudPrice.DataBindings.Add(new Binding("Value", Model.NewStock, "Price", false, DataSourceUpdateMode.OnPropertyChanged));
			cbStockTypes.DataBindings.Add(new Binding("SelectedIndex", Model.NewStock, "StockType", false, DataSourceUpdateMode.OnPropertyChanged));
		}

		public event EventHandler AddStockClicked;
		public event DataGridViewCellFormattingEventHandler DataGridCellFormatting;

		private void ClearInputControls()
		{
			nudPrice.Value = 0;
			nudQuantity.Value = 0;
			cbStockTypes.SelectedIndex = 0;
		}

		private void bAddStock_Click(object sender, EventArgs e)
		{	
			AddStockClicked(this, EventArgs.Empty);
			MessageBox.Show("The stock has been added successfully");
		}

		public void SetDataSource(IList<Stock> stocks)
		{
			dgvStocks.DataSource = stocks;
		}

		public void SetSummaryBindings(SummaryModel equitySummary, SummaryModel bondSummary, SummaryModel fundSummary)
		{
			equitySummaryUserControl.Summary = equitySummary;
			bondSummaryUserControl.Summary = bondSummary;
			fundSummaryUserControl.Summary = fundSummary;
		}

		private void dgvStocks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			DataGridCellFormatting(sender, e);
		}
	}
}
