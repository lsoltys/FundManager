using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundService.Model;

namespace FundManager.Models
{
	public class SummaryModel
	{
		public decimal TotalCount { get; set; }
		public decimal TotalMarketValue { get; set; }
		public decimal TotalStockWeight { get; set; }

	}
}
