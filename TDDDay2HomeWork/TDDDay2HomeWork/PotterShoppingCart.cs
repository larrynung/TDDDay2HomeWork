using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace TDDDay2HomeWork
{
    public class PotterShoppingCart
    {
		#region Fields 
        private IDictionary<Book, int> _goods;
		#endregion Fields 

		#region Properties 
        public IDictionary<Book, int> Goods
        {
            get { return _goods ?? (_goods = new Dictionary<Book, int>()); }
        }
		#endregion Properties 

		#region Methods 
        private decimal GetDiscount(int volume)
        {
            switch (volume)
            {
                case 1:
                    return 1m;
                case 2:
                    return 0.95m;
                case 3:
                    return 0.9m;
                case 4:
                    return 0.8m;
                case 5:
                    return 0.75m;
                default:
                    throw new ArgumentOutOfRangeException("bookCount");
            }
        }
        public Decimal CalculateTotalPrice()
        {
            var totalPrice = 0m;
            var goods = this.Goods;
            var bookCounts = goods
                .Select(item => item.Value)
                .Where(item => item > 0)
                .Distinct()
                .OrderBy(item => item);

            var previousBookCount = 0;
            foreach (var bookCount in bookCounts)
            {
                var incBookCount = bookCount - previousBookCount;
                var books = goods.Where(item => item.Value >= bookCount).ToArray();
                var disCount = GetDiscount(books.Length);
                var booksPrice = books.Sum(item => item.Key.Dollar) * incBookCount * disCount;

                totalPrice += booksPrice;

                previousBookCount = bookCount;
            }
            return totalPrice;
        }
		#endregion Methods 
    }
}