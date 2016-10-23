using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundService.Model;

namespace FundManager.Models
{
	public class Stock
	{
		public StockType StockType { get; set; }
		
		public string Name	{ get; set; }

		public decimal Price { get; set; }

		public decimal Quantity { get; set; }

		public decimal MarketValue
		{
			get { return GetStockMarketValue(Price, Quantity); }
		}

		public decimal TransactionCost
		{
			get { return GetStockTransactionCost(MarketValue, StockType); }
		}

		private decimal GetStockMarketValue(decimal price, decimal quantity)
		{
			return Math.Round(price * quantity, 2, MidpointRounding.AwayFromZero);
		}

		private decimal GetStockTransactionCost(decimal marketValue, StockType stockType)
		{
			switch (stockType)
			{
				case StockType.Equity:
					return Math.Round(marketValue * Constants.PERCENTAGE_COST_OF_EQUITY, 2,  MidpointRounding.AwayFromZero);
				case StockType.Bond:
					return Math.Round(marketValue * Constants.PERCENTAGE_COST_OF_BOND, 2, MidpointRounding.AwayFromZero);
				default:
					throw new NotImplementedException();
			}
		}

		public decimal StockWeight { get; set; }

		public bool ShouldNameBeRed(decimal tolerance)
		{
			return MarketValue < 0 || TransactionCost > tolerance;
		}
	}
}
