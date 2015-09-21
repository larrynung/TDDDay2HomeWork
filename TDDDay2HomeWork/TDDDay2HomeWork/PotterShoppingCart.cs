using System;
using System.Collections;
using System.Collections.Generic;

namespace TDDDay2HomeWork
{
    public class PotterShoppingCart
    {
        public PotterShoppingCart()
        {
        }

        public IDictionary<Book, int> Goods { get; set; }

        public Decimal CalculateTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}