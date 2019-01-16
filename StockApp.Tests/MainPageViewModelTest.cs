using System;
using StockApp.Contracts.Services;
using StockApp.Tests.Mocks;
using StockApp.ViewModels;
using Xamarin.Forms;
using Xunit;

namespace StockApp.Tests
{
    public class MainPageViewModelTest
    {
        [Fact]
        public void CheckStocksAreCreatedInConstructor()
        {
            var mockStockDataService = new MockStockDataService();
            var mainPageViewModel = new MainPageViewModel(mockStockDataService);

            Assert.NotNull(mainPageViewModel.Stocks);
            Assert.Equal("fb", mainPageViewModel.Stocks[0].Name);
            Assert.Equal(3, mainPageViewModel.Stocks.Count);
        }

    }
}
