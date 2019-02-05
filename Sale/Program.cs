using System;
using System.Collections.Generic;
using System.Text;
using Sale.Entities;
using Sale.Entities.Enum;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implemented the interaction with the user
            Console.WriteLine("Enter client data: ");
            Console.Write("Name:  ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string mail = Console.ReadLine();
            Console.Write("Birth Date (dd/mm/yyyy): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the order status: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //instantiated Classes
            Client client = new Client(name, mail, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            //Another interaction with the user
            Console.WriteLine("How many itens you want to order?: ");
            int n = int.Parse(Console.ReadLine());

            //Implemented a "for" because of the interaction "HOW MANY ITENS...."
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($" Enter the {i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price:  "  );
                double price = double.Parse(Console.ReadLine());

                //instantiated the class Product
                Product productItem = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                //instantiated the class OrderItem
                OrderItem orderItem = new OrderItem(quantity, price, productItem);

                //Method to add Itens
                order.AddItem(orderItem);
                }


            Console.WriteLine();
            Console.WriteLine("Order summary" );
            Console.WriteLine(order);




        }
    }
}
