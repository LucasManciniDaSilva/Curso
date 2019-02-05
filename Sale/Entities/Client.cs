using System;
namespace Sale.Entities
{
    //Created the Client Class
    public class Client
    {
        //Defined the variables
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }

        //Created the constructor without arguments
        public Client()
        {
        }
        //Created the constructor with arguments
        public Client(string name, string mail, DateTime birthDate)
        {
            Name = name;
            Mail = mail;
            BirthDate = birthDate;
        }

        //Converted the class to String
        public override string ToString()
        {
            return Name
                + " "
                + BirthDate.ToString("dd/MM/yyyy")
                + " - "
                + Mail;
        }
    }
}
