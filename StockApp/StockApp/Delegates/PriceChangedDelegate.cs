using System;
using StockApp.Models;

namespace StockApp.Delegates
{
    public delegate void PriceChangedDelegate(Stock stock, double PreviousPrice, double CurrentPrice);
}
