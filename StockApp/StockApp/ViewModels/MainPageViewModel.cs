using StockApp.Contracts.Services;
using StockApp.Models;
using StockApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp.ViewModels
{
    public class MainPageViewModel
    {

        public List<Stock> Stocks;

        public MainPageViewModel()
        {

            Stocks = new StockDataService().GetAllStocks();

        }
    }
}
