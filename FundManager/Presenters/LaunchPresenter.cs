using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FundManager.Models;
using FundManager.Services;
using FundManager.Views;
using FundService;
using WinFormsMvp;

namespace FundManager.Presenters
{
	public class LaunchPresenter : Presenter<ILaunchView>
	{
		private IFundService _fundService;
		private IConvertService _convertService;
		public LaunchPresenter(ILaunchView view) : base(view)
		{
			_fundService = new FundService.FundService();
			_convertService = new ConvertService();
			View.AddStockClicked += View_AddStockClicked;
			View.Load += View_Load;
			View.DataGridCellFormatting += View_DataGridCellFormatting1;
		}

		private void View_DataGridCellFormatting1(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var dataGrid = (DataGridView)sender;
			if (e.ColumnIndex == dataGrid.Columns["Name"].Index)
			{
				var stock = (Stock)dataGrid.Rows[e.RowIndex].DataBoundItem;				
				decimal tolerance;
				if (Config.Instance.StockNameColorConfig.TryGetValue(stock.StockType, out tolerance))
				{
					var cellShouldBeRed = stock.ShouldNameBeRed(tolerance);
					if (cellShouldBeRed)
						e.CellStyle.ForeColor = System.Drawing.Color.Red;
				}
			}
		}

		private void View_Load(object sender, EventArgs e)
		{
			View.Model = new Models.LaunchModel();
			var stocks = _fundService.GetAllStocks();
			var summary = _fundService.CalculateSummary();
			View.SetDataSource(new List<Stock>(stocks.Select(s => _convertService.StockConvert(s, summary.AllSummary.TotalMarketValue)).ToList()));
			View.Model.EquitySummary = _convertService.SummaryConvert(summary.EquitySummary);
			View.Model.BondSummary = _convertService.SummaryConvert(summary.BondSummary);
			View.Model.FundSummary = _convertService.SummaryConvert(summary.AllSummary);
			View.SetSummaryBindings(View.Model.EquitySummary, View.Model.BondSummary, View.Model.FundSummary);
		}

		private void View_AddStockClicked(object sender, EventArgs e)
		{			
			var newStock = View.Model.NewStock;
			_fundService.AddStock(new FundService.Model.Stock() { Price = newStock.Price, Quantity = newStock.Quantity, StockType = (FundService.Model.StockType)newStock.StockType} );
			var stocks = _fundService.GetAllStocks();
			var summary = _fundService.CalculateSummary();
			View.SetDataSource(stocks.Select(s => _convertService.StockConvert(s, summary.AllSummary.TotalMarketValue)).ToList());
			View.Model.EquitySummary = _convertService.SummaryConvert(summary.EquitySummary);
			View.Model.BondSummary = _convertService.SummaryConvert(summary.BondSummary);
			View.Model.FundSummary = _convertService.SummaryConvert(summary.AllSummary);
			View.SetSummaryBindings(View.Model.EquitySummary, View.Model.BondSummary, View.Model.FundSummary);
			View.Model.NewStock.Reset();
		}
	}
}
