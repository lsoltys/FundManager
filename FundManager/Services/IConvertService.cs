using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundManager.Models;

namespace FundManager.Services
{
	public interface IConvertService
	{
		SummaryModel SummaryConvert(FundService.Model.Summary summary);
		Stock StockConvert(FundService.Model.Stock stock, decimal totalFundMarketValue);
	}
}
