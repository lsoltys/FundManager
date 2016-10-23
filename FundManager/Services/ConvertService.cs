using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Services
{
	public class ConvertService : IConvertService
	{
		public Models.Stock StockConvert(FundService.Model.Stock stock, decimal totalFundMarketValue)
		{
			return new Models.Stock()
			{
				Name = stock.Name,
				Price = stock.Price,
				Quantity = stock.Quantity,
				StockType = stock.StockType,
				StockWeight = totalFundMarketValue == 0M ? 0M : Math.Round((stock.Price * stock.Quantity) / totalFundMarketValue * 100, 4, MidpointRounding.AwayFromZero)
			};
		}

		public Models.SummaryModel SummaryConvert(FundService.Model.Summary summary)
		{
			return new Models.SummaryModel()
			{
				TotalCount = summary.TotalCount,
				TotalMarketValue = summary.TotalMarketValue,
				TotalStockWeight = summary.TotalStockWeight
			};
		}
	}
}
