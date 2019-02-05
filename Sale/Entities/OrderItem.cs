using System;
using System.Text;
namespace Sale.Entities
{
    //Created the OrderItem class
    public class OrderItem
    {
        //Defined the variables
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }

        //Created the method without arguments
        public OrderItem()
        {
        }

        //Created the method with arguments
        public OrderItem(int quantity, double price, Product products)
        {
            Quantity = quantity;
            Price = price;
            Products = products;
        }

        //Created an operation to do the subtotal of the items
        public double SubTotal()
        {
            return Price * Quantity;
        }

        //Converted the class to a String

        public override string ToString()
        {
            return Products.Name
                + ", "
                + Price.ToString()
                + ", "
                + Quantity
                + ", SubTotal:  "
                + SubTotal().ToString();
        }
    }
}
