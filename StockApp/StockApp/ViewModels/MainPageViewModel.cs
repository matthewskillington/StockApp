using StockApp.Contracts.Services;
using StockApp.Models;
using StockApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StockApp.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private ObservableCollection<Stock> _stocks;

        public ObservableCollection<Stock> Stocks
        {
            get => _stocks;
            set
            {
                if(value != _stocks)
                {
                    _stocks = value;
                    OnPropertyChanged();
                }
            }
        }

        public IStockDataService _stockDataService;

        public MainPageViewModel(IStockDataService stockDataService)
        {

            _stockDataService = stockDataService;
            var stockList = stockDataService.GetAllStocks();

            Stocks = new ObservableCollection<Stock>();
            foreach(var stock in stockList)
            {
                Stocks.Add(stock);
            }

        }

        public ICommand UpdateCommand => new Command(OnUpdatePrices);

        private void OnUpdatePrices()
        {
            Stocks[0].Price = 126.10;
        }
        

    }
}
