using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundService.Model
{
	public class FundSummary
	{

		public FundSummary(Summary equitySummary, Summary bondSummary, Summary allSummary)
		{
			EquitySummary = equitySummary;
			BondSummary = bondSummary;
			AllSummary = allSummary;
		}

		public Summary EquitySummary { get; private set; }
		public Summary BondSummary { get; private set; }
		public Summary AllSummary { get; private set; }
	}
}
