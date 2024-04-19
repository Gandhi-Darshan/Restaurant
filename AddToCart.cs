using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class AddToCart
    {
        public string DishName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public AddToCart(string dishName, int quantity, decimal price)
        {
            DishName = dishName;
            Quantity = quantity;
            Price = price;
        }

        public decimal TotalAmount
        {
            get { return Quantity * Price; }
        }

        public override string ToString()
        {
            return $"{DishName} - Quantity : {Quantity} - Price : {Price:C}";
        }
    }
}
