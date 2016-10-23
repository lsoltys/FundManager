using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundManager.Models;
using FundManager.Views;

namespace FundManagerControllerTests
{
	public class MockLaunchView : ILaunchView
	{
		public LaunchModel Model
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public bool ThrowExceptionIfNoPresenterBound
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public event EventHandler AddStockClicked;
		public event System.Windows.Forms.DataGridViewCellFormattingEventHandler DataGridCellFormatting;
		public event EventHandler Load;

		public void SetDataSource(IList<Stock> stocks)
		{
			throw new NotImplementedException();
		}

		public void SetSummaryBindings(SummaryModel equitySummary, SummaryModel bondSummary, SummaryModel fundSummary)
		{
			throw new NotImplementedException();
		}

		public int AddStockClickedListenerCount
		{
			get
			{
				if (AddStockClicked != null)
				{
					return AddStockClicked.GetInvocationList().Count();
				}
				return 0;
			}
		}

		public int LoadListenerCount
		{
			get
			{
				if (Load != null)
				{
					return Load.GetInvocationList().Count();
				}
				return 0;
			}
		}

	}
}
