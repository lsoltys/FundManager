using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FundManager.Models;
using WinFormsMvp;

namespace FundManager.Views
{
	public interface ILaunchView : IView<LaunchModel>
	{
		event EventHandler AddStockClicked;
		event DataGridViewCellFormattingEventHandler DataGridCellFormatting;
		void SetDataSource(IList<Stock> stocks);
		void SetSummaryBindings(SummaryModel equitySummary, SummaryModel bondSummary, SummaryModel fundSummary);
	}
}
