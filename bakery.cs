using System;
using System.Collections.Generic;

namespace PierresBakery
{
    public class Bakery
    {
        public string Offer;
        public int Price;
    }
    public class Program
    {
        
        public static void Main()
        {
            Bakery singleBread = new Bakery();
            singleBread.Offer = "One baguette";
            singleBread.Price = 5;

            Bakery breadDeal = new Bakery();
            breadDeal.Offer = "Buy two get one free bread";
            breadDeal.Price = 10;

            Bakery singlePastry = new Bakery();
            singlePastry.Offer = "One pastry";
            singlePastry.Price = 2;
            
            Bakery threePastries = new Bakery();
            threePastries.Offer = "3 pastries";
            threePastries.Price = 5;

            Console.WriteLine("Welcome to Pierre's Bakery! I am currently having a sale! one baguette for $5 or buy two get one free. I also have a sale on pastries, one for $2 or 3 for $5! What can I get you today? (b, 3b, p, 3p)");
            string customerChoice = Console.ReadLine();
            Console.WriteLine(customerChoice);

            if(customerChoice == "b")
            {
                Console.WriteLine(singleBread.Offer + " for $" + singleBread.Price);
                Console.WriteLine("Would you like to add a drink? (Y/N");
                Console.ReadLine();
            }

            if (customerChoice == "3b")
            {
                Console.WriteLine(breadDeal.Offer + " for $" + breadDeal.Price);
            }

            if (customerChoice == "p")
            {
                Console.WriteLine(singlePastry.Offer + " for $" + singlePastry.Price);
            }
            
            if (customerChoice == "3p")
            {
                Console.WriteLine(threePastries.Offer + " for $" + threePastries.Price);
            }
        }
    }
}