using System;
using System.Collections.Generic;
using StockApp.Contracts.Services;
using StockApp.Models;

namespace StockApp.Tests.Mocks
{
    public class MockStockDataService : IStockDataService
    {

        private readonly List<Stock> Stocks = new List<Stock>
        {
            new Stock("fb", 125.06),
            new Stock("msft", 95.34),
            new Stock("atvi", 46.42)
        };

        public Stock GetStockByName(string name)
        {
            Stock result;

            result = Stocks.Find(x => x.Name.Equals(name));

            return result;
        }

        public List<Stock> GetAllStocks()
        {
            return Stocks;
        }

        public void UpdateStockPrice(Stock stock, double newPrice)
        {
            Stock selected = GetStockByName(stock.Name);

            selected.Price = newPrice;
        }
    }
}
