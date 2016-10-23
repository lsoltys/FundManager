using System;
using System.Collections.Generic;
using FundManager;
using FundManager.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockInformationTests
{
	[TestClass]
	public class StockInformationTests
	{
		FundManager.Models.Stock _equity1;
		FundManager.Models.Stock _equity2;
		FundManager.Models.Stock _bond1;
		FundManager.Models.Stock _bond2;
		FundService.IFundService _fundService;
		IConvertService _convertService;
		IList<FundService.Model.Stock> _stocks;
		FundService.Model.FundSummary _summary;

		[TestInitialize]
		public void Setup()
		{
			_convertService = new ConvertService();
			_fundService = new FundService.FundService();
			_fundService.AddStock(new FundService.Model.Stock() { Price = 23.45M, Quantity = 15.4567M, StockType = FundService.Model.StockType.Equity });
			_fundService.AddStock(new FundService.Model.Stock() { Price = 99.23M, Quantity = 9.4532M, StockType = FundService.Model.StockType.Bond });
			_fundService.AddStock(new FundService.Model.Stock() { Price = 9.22M, Quantity = 88.91M, StockType = FundService.Model.StockType.Equity });
			_fundService.AddStock(new FundService.Model.Stock() { Price = 1923.45M, Quantity = 1000M, StockType = FundService.Model.StockType.Bond });			
			_stocks = new List<FundService.Model.Stock>(_fundService.GetAllStocks());
			_summary = _fundService.CalculateSummary();
			_equity1 = _convertService.StockConvert(_stocks[0], _summary.AllSummary.TotalMarketValue);
			_bond1 = _convertService.StockConvert(_stocks[1], _summary.AllSummary.TotalMarketValue);
			_equity2 = _convertService.StockConvert(_stocks[2], _summary.AllSummary.TotalMarketValue);
			_bond2 = _convertService.StockConvert(_stocks[3], _summary.AllSummary.TotalMarketValue);
		}


		[TestMethod]
		public void StockMarketValueCalculatedProperly()
		{
			Assert.AreEqual(362.46M, _equity1.MarketValue);
			Assert.AreEqual(938.04M, _bond1.MarketValue);
		}

		[TestMethod]
		public void StockTransactionCostCalculatedProperly()
		{
			Assert.AreEqual(1.81M, _equity1.TransactionCost);
			Assert.AreEqual(18.76M, _bond1.TransactionCost);
		}

		[TestMethod]
		public void StockWeightCalculatedProperly()
		{			
			Assert.AreEqual(0.0188M, _equity1.StockWeight);
			Assert.AreEqual(0.0487M, _bond1.StockWeight);
			Assert.AreEqual(0.0426M, _equity2.StockWeight);
			Assert.AreEqual(99.8899M, _bond2.StockWeight);
		}

		[TestMethod]
		public void NameShouldNotBeHiglightedRed()
		{
			Assert.IsFalse(_equity1.ShouldNameBeRed(Constants.TRANSACTION_COST_TOLERANCE_FOR_EQUITY));
			Assert.IsFalse(_bond1.ShouldNameBeRed(Constants.TRANSACTION_COST_TOLERANCE_FOR_BOND));
			Assert.IsFalse(_equity1.ShouldNameBeRed(Constants.TRANSACTION_COST_TOLERANCE_FOR_EQUITY));
			Assert.IsFalse(_bond2.ShouldNameBeRed(Constants.TRANSACTION_COST_TOLERANCE_FOR_BOND));
		}

		[TestMethod]
		public void NameShouldBeHighlightedRed()
		{
			var fundService1 = new FundService.FundService();
			var convertService1 = new ConvertService();
			fundService1.AddStock(new FundService.Model.Stock() { Price = 5000M, Quantity = 5000M, StockType = FundService.Model.StockType.Bond });			
			var tempStocks = new List<FundService.Model.Stock>(fundService1.GetAllStocks());
			var tempSummary = fundService1.CalculateSummary();
			var equity = convertService1.StockConvert(tempStocks[0], tempSummary.AllSummary.TotalMarketValue);

			Assert.IsTrue(equity.ShouldNameBeRed(Constants.TRANSACTION_COST_TOLERANCE_FOR_BOND));
		}
	}
}
