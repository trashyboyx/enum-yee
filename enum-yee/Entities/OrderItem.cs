using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace enum_yee.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product, double price)
        {
            Quantity = quantity;
            Product = product;
            Price = price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name 
                    + ", $" 
                    + Price 
                    + ", Quantity: " 
                    + Quantity 
                    + ", SubTotal: $" 
                    + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
