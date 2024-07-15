using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Factory_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Customer type");
            string type = Console.ReadLine().ToUpper();


            /*   Customer c;
               switch (type)
               {
                   case "SILVER":
                       c = new SilverCustomer();
                       break;
                   case "GOLDEN":
                       c = new GoldenCustomer();
                       break;
                   case "PLATINUM":
                       c = new PlatinumCustomer();
                       break;
                   default
                       : c = new Customer();
                       break;



               }
               c.print();
               Console.ReadLine();*/



            // but here the problem is when we want to access 50 object, so that time we need to create that 
            // object  or when we want exted some property that time we go change 50 time 

            // so reduce that problem we can crete one more class and we write that logic on it.

            Customer c=CustomerFactory.create(type);
            c.print();
            Console.ReadLine();

        }
    }
    public class CustomerFactory
    {
        public static Customer create(string type)
        {
            switch (type)

            {
                case "SILVER":
                    return new SilverCustomer();

                case "GOLDEN":
                    return new GoldenCustomer();

                case "PLATINUM":
                    return new PlatinumCustomer();

                default
                :
                    return new Customer();




            }
        }
    }




    public class Customer
    {
        public virtual void print()
        {
            Console.WriteLine("customer print method called");
        }

    }
    public class SilverCustomer : Customer
    {
        public override void print()
        {
            Console.WriteLine("Silver method Print method called");
        }
    }
    public class GoldenCustomer : Customer
    {
        public override void print()
        {
            Console.WriteLine("Golden method Print method called");
        }
    }
    public class PlatinumCustomer : Customer
    {
        public override void print()
        {
            Console.WriteLine("Platinum method Print method called");
        }
    }
}


