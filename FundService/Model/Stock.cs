using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundService.Model
{
	public class Stock
	{
		public StockType StockType { get; set; }
		
		public string Name { get; set; }

		public decimal Price { get; set; }

		public decimal Quantity { get; set; }
	}
}
