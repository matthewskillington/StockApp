using StockApp.Contracts.Services;
using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp.Services
{
    public class StockDataService : IStockDataService
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
    }
}
