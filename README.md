# FundManagerApplication
TestFundManager

Remarks!
There was no info that data must be stored in any way so in my solution there is no storing to any database. 

My solution consists of:
- FundService with 3 methods:
		- void AddStock(Stock stock)
		- IEnumerable<Stock> GetAllStocks()
		- FundSummary CalculateSummary()

- WinForms application which is based on MVP (model-view-presenter) pattern

- Tests for FundService
- Tests for presenter
- Tests for model
