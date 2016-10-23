using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Models
{
	public class NewStock : INotifyPropertyChanged
	{
		public int StockType { get; set; }

		public decimal Price { get; set; }

		public decimal Quantity { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public void Reset()
		{
			Price = Quantity = 0;
			StockType = 0;
			PropertyChanged(this, new PropertyChangedEventArgs("Price"));
			PropertyChanged(this, new PropertyChangedEventArgs("StockType"));
			PropertyChanged(this, new PropertyChangedEventArgs("Quantity"));
		}
	}
}
