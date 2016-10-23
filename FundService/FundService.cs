using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundService.Model;

namespace FundService
{
	public class FundService : IFundService
	{
		private IList<Stock> Stocks { get; set; } = new List<Stock>();
		private IEnumerable<Stock> Bonds => Stocks.Where(s => s.StockType == StockType.Bond);
		private IEnumerable<Stock> Equities => Stocks.Where(s => s.StockType == StockType.Equity);

		public void AddStock(Stock stock)
		{
			stock.Name = $"{stock.StockType.ToString()}{Stocks.Where(s => s.StockType == stock.StockType).Count() + 1}";
			Stocks.Add(stock);
		}

		public IEnumerable<Stock> GetAllStocks()
		{
			return Stocks;
		}

		public FundSummary CalculateSummary()
		{
			var equityTotalMarketValue = Equities.Sum(sl => Math.Round(sl.Quantity * sl.Price, 2, MidpointRounding.AwayFromZero));
			var bondTotalMarketValue = Bonds.Sum(sl => Math.Round(sl.Quantity * sl.Price, 2, MidpointRounding.AwayFromZero));
			var fundTotalMarketValue = equityTotalMarketValue + bondTotalMarketValue;

			var equityTotalNumber = Equities.Count();
			var bondTotalNumber = Bonds.Count();
			var fundTotalNumber = equityTotalNumber + bondTotalNumber;

			var equityTotalStockWeight = fundTotalMarketValue == 0M ? 0M : Math.Round(equityTotalMarketValue / fundTotalMarketValue * 100, 4, MidpointRounding.AwayFromZero);
			var bondTotalStockWeight = fundTotalMarketValue == 0M ? 0M : Math.Round(bondTotalMarketValue / fundTotalMarketValue * 100, 4, MidpointRounding.AwayFromZero);

			var equitySummary = new Summary(equityTotalNumber, equityTotalStockWeight, equityTotalMarketValue);
			var bondSummary = new Summary(bondTotalNumber, bondTotalStockWeight, bondTotalMarketValue);
			var allSummary = new Summary(fundTotalNumber, Stocks.Count() == 0 ? 0 : 100, fundTotalMarketValue);

			return new FundSummary(equitySummary, bondSummary, allSummary);
		}
	}
}
