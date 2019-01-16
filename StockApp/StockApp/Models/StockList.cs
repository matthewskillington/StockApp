using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp.Models
{
    public class StockList
    {
        public StockList()
        {
            Name = "Empty";
            Stocks = new List<Stock>();
        }

        public string Name;
        public List<Stock> Stocks;

        public void AddStock(Stock stock)
        {
            Stocks.Add(stock);
        }

        public void AddMultiple(List<Stock> stocks)
        {
            Stocks.AddRange(stocks);
        }

        public List<Stock> GetAll()
        {
            return Stocks;
        }
    }
}
