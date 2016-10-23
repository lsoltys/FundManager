# FundManagerApplication
Technical Exercise - Equities Software Engineer Position

<h3>Remarks!</h3>
There was no info that data must be stored in any way so in my solution there is no storing to any database. 

My solution consists of:
- FundService with 3 methods:<br>
		- void AddStock(Stock stock)<br>
		- IEnumerable<Stock> GetAllStocks()<br>
		- FundSummary CalculateSummary()
- WinForms application which is based on MVP (model-view-presenter) pattern
- Tests for FundService
- Tests for presenter
- Tests for model
