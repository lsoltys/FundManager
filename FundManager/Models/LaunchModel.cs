using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundService.Model;

namespace FundManager.Models
{
	public class LaunchModel
	{
		public LaunchModel()
		{
			NewStock = new NewStock();
			Stocks = new List<FundManager.Models.Stock>();
			List<string> stockTypes = new List<string>();
			foreach (FundService.Model.StockType stockType in Enum.GetValues(typeof(FundService.Model.StockType)))
			{
				stockTypes.Add(stockType.ToString());
			}
			StockTypes = stockTypes;
			EquitySummary = new SummaryModel();
			BondSummary = new SummaryModel();
			FundSummary = new SummaryModel();
		}

		public NewStock NewStock { get; set; }
		public List<string> StockTypes { get; set; }
		public List<Stock> Stocks { get; set; }
		public SummaryModel EquitySummary { get; set; }
		public SummaryModel BondSummary { get; set; }
		public SummaryModel FundSummary { get; set; }

	}
}
