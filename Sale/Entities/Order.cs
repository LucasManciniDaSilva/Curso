using System;
using System.Text;
using System.Collections.Generic;
using Sale.Entities.Enum;
namespace Sale.Entities
{
    //Created the Order class
    public class Order
    {
        //Defined the variables
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public  Client  Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //Created the constructor without arguments
        public Order()
        {
        }

        //Created the constructor with arguments
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Created the method to Add an item
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        //Created the method to Remove an Item
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        //Created an operation to do a sum of the subtotal of items
        public double Total()
        {
            double sum = 0.00;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        //Converted the class to String
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment:  " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items: ");
                foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total: " + Total().ToString());
            return sb.ToString();
        }
    }
}
