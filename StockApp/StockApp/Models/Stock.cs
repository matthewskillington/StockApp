using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Delegates;
using Xamarin.Forms;

namespace StockApp.Models
{
    public class Stock : BindableObject
    {
        public Stock(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
        public string Name { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (Math.Abs(_price - value) > 0.001 && PriceChanged != null)
                {
                    PriceChanged(this, _price, value);
                }

                _price = value;

                OnPropertyChanged();
            }
        }
        protected double _price;

        public event PriceChangedDelegate PriceChanged;
    }
}
