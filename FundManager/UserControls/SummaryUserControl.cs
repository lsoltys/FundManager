using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FundService.Model;
using FundManager.Models;

namespace FundManager.UserControls
{
	public partial class SummaryUserControl : UserControl
	{
		public SummaryUserControl()
		{
			InitializeComponent();			
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
		}

		SummaryModel _summary;
		[Bindable(true)]
		public SummaryModel Summary
		{
			get
			{
				if (_summary == null)
					_summary = new SummaryModel();
				return _summary;
			}
			set
			{
				_summary = value;
				if (_summary != null)
				{
					tbTotalMarketValue.Text = $"{_summary.TotalMarketValue:n2}";
					tbTotalNumber.Text = $"{_summary.TotalCount}";
					tbTotalStockWeight.Text = $"{_summary.TotalStockWeight:n4}";
				}
			}
		}

		[Bindable(true)]
		public string Title
		{
			get
			{
				return gbTitle.Text;
			}
			set
			{
				gbTitle.Text = value;
			}
		}
	}
}
