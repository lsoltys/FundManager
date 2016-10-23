using System;
using System.Collections.Generic;
using FundService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FundServiceTests
{
	[TestClass]
	public class FundServiceTests
	{

		private IFundService _fundService;
		private IList<FundService.Model.Stock> stocks;
		private FundService.Model.Stock testStock;
		
		public void Setup()
		{
			_fundService = new FundService.FundService();
			testStock = new FundService.Model.Stock() { StockType = FundService.Model.StockType.Bond, Quantity = 10M, Price = 134M };
			_fundService.AddStock(testStock);
			stocks = new List<FundService.Model.Stock>(_fundService.GetAllStocks());
		}

		[TestMethod]
		public void GetAllStockReturnsEmptyEnumerableUntillFirstStockIsAdded()
		{
			_fundService = new FundService.FundService();
			var tempStocks = _fundService.GetAllStocks();
			Assert.AreEqual(0, tempStocks.Count());
		}

		[TestMethod]
		public void AddingStockToFundIncrementsListCount()
		{
			this.Setup();
			Assert.AreEqual(1, stocks.Count);
		}

		[TestMethod]
		public void AddingStockToFundAddsStockToList()
		{
			this.Setup();
			Assert.AreEqual(testStock, stocks[0]);
		}

		[TestMethod]
		public void AddingStockToFundAddsStockWithProperName()
		{
			this.Setup();
			Assert.AreEqual("Bond1", stocks[0].Name);
			_fundService.AddStock(new FundService.Model.Stock() { StockType = FundService.Model.StockType.Bond, Price = 1M, Quantity = 1M});
			stocks = new List<FundService.Model.Stock>(_fundService.GetAllStocks());
			Assert.AreEqual("Bond2", stocks[1].Name);
			_fundService.AddStock(new FundService.Model.Stock() { StockType = FundService.Model.StockType.Equity, Price = 1M, Quantity = 1M });
			stocks = new List<FundService.Model.Stock>(_fundService.GetAllStocks());
			Assert.AreEqual("Equity1", stocks[2].Name);
			_fundService.AddStock(new FundService.Model.Stock() { StockType = FundService.Model.StockType.Bond, Price = 1M, Quantity = 1M });
			stocks = new List<FundService.Model.Stock>(_fundService.GetAllStocks());
			Assert.AreEqual("Bond3", stocks[3].Name);
		}

		[TestMethod]
		public void AddingStockToFundRefreshesFundSummaryInProperWay()
		{
			this.Setup();
			var summary = _fundService.CalculateSummary();

			//equity summary
			Assert.AreEqual(0, summary.EquitySummary.TotalCount);
			Assert.AreEqual(0, summary.EquitySummary.TotalMarketValue);
			Assert.AreEqual(0, summary.EquitySummary.TotalStockWeight);

			//bond summary
			Assert.AreEqual(1, summary.BondSummary.TotalCount);
			Assert.AreEqual(1340, summary.BondSummary.TotalMarketValue);
			Assert.AreEqual(100, summary.BondSummary.TotalStockWeight);

			//fund summary
			Assert.AreEqual(1, summary.AllSummary.TotalCount);
			Assert.AreEqual(1340, summary.AllSummary.TotalMarketValue);
			Assert.AreEqual(100, summary.AllSummary.TotalStockWeight);

			_fundService.AddStock(new FundService.Model.Stock() { StockType = FundService.Model.StockType.Equity, Price = 55.98M, Quantity = 3.4563M });
			summary = _fundService.CalculateSummary();

			//equity summary
			Assert.AreEqual(1, summary.EquitySummary.TotalCount);
			Assert.AreEqual(193.48M, summary.EquitySummary.TotalMarketValue);
			Assert.AreEqual(12.6171M, summary.EquitySummary.TotalStockWeight);

			//bond summary
			Assert.AreEqual(1, summary.BondSummary.TotalCount);
			Assert.AreEqual(1340M, summary.BondSummary.TotalMarketValue);
			Assert.AreEqual(87.3829M, summary.BondSummary.TotalStockWeight);

			//fund summary
			Assert.AreEqual(2, summary.AllSummary.TotalCount);
			Assert.AreEqual(1533.48M, summary.AllSummary.TotalMarketValue);
			Assert.AreEqual(100M, summary.AllSummary.TotalStockWeight);

		}

	}
}
