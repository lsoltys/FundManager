using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundService.Model;

namespace FundService
{
    public interface IFundService
    {
		void AddStock(Stock stock);
		IEnumerable<Stock> GetAllStocks();
		FundSummary CalculateSummary();
    }
}
