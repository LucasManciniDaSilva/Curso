namespace Sale.Entities

{
    //Created the Product class
    public class Product
    {
        //Defined the Variables
        public string Name { get; set; }
        public double Price { get; set; }

        //Created the constructor without arguments
        public Product()
        {
        }

        //Created the constructor with arguments
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
