using System;
using System.Collections.Generic;
using System.Linq;
using FundManager.Models;
using FundManager.Presenters;
using FundManager.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundManagerControllerTests
{
	[TestClass]
	public class LaunchPresenterTests
	{
		[TestMethod]
		public void PresenterRegistersAsListenerForAddStockEvent()
		{
			ILaunchView view = new MockLaunchView();
			Assert.AreEqual(0, ((MockLaunchView)view).AddStockClickedListenerCount);
			LaunchPresenter presenter = new LaunchPresenter(view);
			int expectedListenersCount = 1;
			int actualListenersCount = ((MockLaunchView)view).AddStockClickedListenerCount;
			Assert.AreEqual(expectedListenersCount, actualListenersCount);
		}

		[TestMethod]
		public void PresenterRegistersAsListenerForLoadEvent()
		{
			ILaunchView view = new MockLaunchView();
			Assert.AreEqual(0, ((MockLaunchView)view).LoadListenerCount);
			LaunchPresenter presenter = new LaunchPresenter(view);
			int expectedListenersCount = 1;
			int actualListenersCount = ((MockLaunchView)view).LoadListenerCount;
			Assert.AreEqual(expectedListenersCount, actualListenersCount);
		}
	}


}
