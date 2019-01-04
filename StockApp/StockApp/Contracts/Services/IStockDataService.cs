using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp.Contracts.Services
{
    public interface IStockDataService
    {
        List<Stock> GetAllStocks();
        Stock GetStockByName(string name);
    }
}
