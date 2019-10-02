using System;
using Bakery.Models;

namespace PierresBakery
{
    public class Program
    {
        
        public static void Main()
        {
            Bread singleBread = new Bread();
            singleBread.Offer = "One baguette";
            singleBread.Price = 5;

            Bread breadDeal = new Bread();
            breadDeal.Offer = "Buy two get one free baguette";
            breadDeal.Price = 10;

            Pastry singlePastry = new Pastry();
            singlePastry.Offer = "One pastry";
            singlePastry.Price = 2;
            
            Pastry threePastries = new Pastry();
            threePastries.Offer = "3 pastries";
            threePastries.Price = 5;
            // prints out ascii art
            var arr = new[]
							{   @" ____________________________________________ ",
                                @"|               Pierre's Bakery              |",
                                @"|____________________________________________|",
                                @"|__||  ||___||  |_|___|___|__|  ||___||  ||__|",
                                @"||__|  |__|__|  |___|___|___||  |__|__|  |__||",
                                @"|__||  ||___||  |_|___|___|__|  ||___||  ||__|",
                                @"||__|  |__|__|  |    || |    |  |__|__|  |__||",
                                @"|__||  ||___||  |    || |    |  ||___||  ||__|",
                                @"||__|  |__|__|  |    || |    |  |__|__|  |__||",
                                @"|__||  ||___||  |    || |    |  ||___||  ||__|",
                                @"||__|  |__|__|  |    || |    |  |__|__|  |__||",
                                @"|__||  ||___||  |   O|| |O   |  ||___||  ||__|",
                                @"||__|  |__|__|  |    || |    |  |__|__|  |__||",
                                @"|__||  ||___||  |    || |    |  ||___||  ||__|",
                                @"||__|  |__|__|__|____||_|____|  |__|__|  |__||",
                                @"|LLL|  |LLLLL|______________||  |LLLLL|  |LLL|",
                                @"|LLL|  |LLL|______________|  |  |LLLLL|  |LLL|",
                                @"|LLL|__|L|______________|____|__|LLLLL|__|LLL|",   
							};

				Console.WriteLine("\n\n");
				foreach(string line in arr )
				Console.WriteLine(line);

            Console.WriteLine("Welcome to Pierre's Bakery! I am currently having a sale! one baguette for $5(b), or buy two get one free(3b). I also have a sale on pastries(p), one for $2 or 3 for $5(3p)! What can I get you today?");
            string customerChoice = Console.ReadLine();
            if (customerChoice == "b")
            {
                singleBread.GetDetails(customerChoice);
            }
            if (customerChoice == "3b")
            {
                breadDeal.GetDetails(customerChoice);
            }
            if (customerChoice == "p")
            {
                singlePastry.GetDetails(customerChoice);
            }
            
            if (customerChoice == "3p")
            {
                threePastries.GetDetails(customerChoice);
            }
        }
    }
}