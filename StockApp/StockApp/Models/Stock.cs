using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp.Models
{
    public class Stock
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
                /*if (_price != value && PriceChanged != null)
                {
                    PriceChanged(Name, _price, value);
                }*/

                _price = value;
            }
        }
        protected double _price;
    }
}
