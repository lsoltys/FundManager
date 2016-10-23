using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundService.Model
{
	public class Summary
	{

		public Summary(decimal totalCount, decimal totalStockWeight, decimal totalMarketValue)
		{
			TotalCount = totalCount;
			TotalStockWeight = totalStockWeight;
			TotalMarketValue = totalMarketValue;
		}

		public decimal TotalCount { get; private set; }
		public decimal TotalMarketValue { get; private set; }
		public decimal TotalStockWeight { get; private set; }
	}
}
