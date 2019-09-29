using System;
using System.Collections.Generic;
// using System.String;

namespace PierresBakery
{
    public class Bakery
    {
        public string Offer;
        public int Price;
        public void GetBakery(string customerChoice)
        {
             Console.WriteLine("What kind would you like?");
            string type = Console.ReadLine();

            Console.WriteLine("Would you like to add a drink? (Y/N)");
             string adding = Console.ReadLine();
               if (adding == "Y" || adding == "y")
               {
                    Console.WriteLine("Drink options: Fruit Juice(F) $1, soda(S) $2, coffee(C) $4, tea(T) $2");
                    string drink = Console.ReadLine();

                   if (drink == "F" || drink == "f")
                    {
                        int newPrice = (int)(1 + Price);
                        Console.WriteLine(Offer + ": " + type + " $" + Price);
                        Console.WriteLine("Fruit Juice $1");
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "S" || drink == "s")
                    {
                        int newPrice = (int)(2 + Price);
                        Console.WriteLine(Offer + ": " + type + " $" + Price);
                        Console.WriteLine("Soda $2");
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "C" || drink == "c")
                    {
                        int newPrice = (int)(4 + Price);
                        Console.WriteLine(Offer + ": " + type + " $" + Price);
                        Console.WriteLine("Coffee $4");
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "T" || drink == "t")
                    {
                        int newPrice = (int)(2 + Price);
                        Console.WriteLine(Offer + ": " + type + " $" + Price);
                        Console.WriteLine("Tea $2");
                        Console.WriteLine("your total is $" + newPrice);
                    }
                }
                else
                {
                    var dol = new[]
							{   
                                @"                 .:xxl.                 ",
                                @"            .,codONMMNOdol;.            ",
                                @"          'dKWMMMMMMMMMMMMWXk;          ",
                                @"         :KMMMMMNKNMMWXWMMMMMNd.        ",
                                @"        '0MMMMMXc kMMK cKNXXKOd'        ",
                                @"        ;XMMMMMXl OMM0                  ",
                                @"        .OMMMMMMWXNMMXo,..              ",
                                @"         ,OWMMMMMMMMMMMWX0xl,.          ",
                                @"          .:x0NWMMMMMMMMMMMMW0c.        ",
                                @"             ..;cxXMMMWWMMMMMMWd.       ",
                                @"                  kMMK.cOWMMMMMX:       ",
                                @"       .lxkOO00   kMM0  .OMMMMMN:       ",
                                @"       .xWMMMMMX  OMMK .oXMMMMMO.       ",
                                @"        .dNMMMMMWNWMMWXXWMMMMWk'        ",
                                @"          ,dKNMMMMMMMMMMMMWXk:.         ",
                                @"            .,:lokXMMNOdoc;.            ",
                                @"                 .kMM0'                 ",
                                @"                 ;ll:.                  ",
							};

				Console.WriteLine("\n\n");
				foreach(string line in dol)
				Console.WriteLine(line); 
                
                  Console.WriteLine("your total for " + Offer +": "+ type + " $" + Price);
                 System.Environment.Exit(1);
                }

        }
    }
    public class Program
    {
        
        public static void Main()
        {
            Bakery singleBread = new Bakery();
            singleBread.Offer = "One baguette";
            singleBread.Price = 5;

            Bakery breadDeal = new Bakery();
            breadDeal.Offer = "Buy two get one free baguette";
            breadDeal.Price = 10;

            Bakery singlePastry = new Bakery();
            singlePastry.Offer = "One pastry";
            singlePastry.Price = 2;
            
            Bakery threePastries = new Bakery();
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
            singleBread.GetBakery(customerChoice);
            }
            if (customerChoice == "3b")
            {
                breadDeal.GetBakery(customerChoice);
            }
            if (customerChoice == "p")
            {
                singlePastry.GetBakery(customerChoice);
            }
            if (customerChoice == "3p")
            {
                threePastries.GetBakery(customerChoice);
            }

        }
    }
}