using System;
using System.Collections.Generic;

namespace PierresBakery
{
    public class Bakery
    {
        public string Deal;
        public int Price;
    }
    public class Items
    {
        public static void Main()
        {
            Bakery singleBread = new Bakery("One baguette", 5);
            Bakery breadDeal = new Bakery("Buy two get one free bread!", 10);
            Bakery singlePastry = new Bakery("One Pastry", 2);
            Bakery threePastries = new Bakery("3 for $5 pastries", 5)

            Console.WriteLine("Welcome to Pierre's Bakery! I am currently having a sale! one baguette for $5 or buy two get one free. I also have a sale on pastries, one for $2 or 3 for $5! What can I get you today? (b, 3b, pm 3p)");
            string customerChoice = Console.ReadLine();
            Console.WriteLine(customerChoice);
        }
    }
}