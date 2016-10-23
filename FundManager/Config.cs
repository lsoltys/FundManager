using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager
{
	public sealed class Config
	{
		private static readonly Config _instance = new Config();

		static Config()
		{
		}

		public static Config Instance
		{
			get
			{
				return _instance;
			}
		}

		public IDictionary<FundService.Model.StockType, decimal> StockNameColorConfig = new Dictionary<FundService.Model.StockType, decimal>()
		{
			{ FundService.Model.StockType.Equity, Constants.TRANSACTION_COST_TOLERANCE_FOR_EQUITY },
			{ FundService.Model.StockType.Bond, Constants.TRANSACTION_COST_TOLERANCE_FOR_BOND}
		};
	}
}
