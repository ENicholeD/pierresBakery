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

            Console.WriteLine("Welcome to Pierre's Bakery! I am currently having a sale! one baguette for $5 or buy two get one free. I also have a sale on pastries, one for $2 or 3 for $5! What can I get you today? (b, 3b, p, 3p)");
            string customerChoice = Console.ReadLine();
            Console.WriteLine(customerChoice);

            // single loaf of bread
            if(customerChoice == "b")
            {
                Console.WriteLine("Would you like to add a drink? (Y/N)");
                string adding = Console.ReadLine();
                if (adding == "Y" || adding == "y")
                {
                    Console.WriteLine("Drink options: Fruit Juice(F) $1, soda(S) $2, coffee(C) $4, tea(T) $2");
                    string drink = Console.ReadLine();

                    if (drink == "F" || drink == "f")
                    {
                        int newPrice = (int)(1 + singleBread.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "S" || drink == "s")
                    {
                        int newPrice = (int)(2 + singleBread.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "C" || drink == "c")
                    {
                        int newPrice = (int)(4 + singleBread.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "T" || drink == "t")
                    {
                        int newPrice = (int)(2 + singleBread.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                }
                else
                {
                    Console.WriteLine("your total for " + singleBread.Offer + " is $" + singleBread.Price);
                    System.Environment.Exit(1);    
                }
            }
            
            // buy two get one free bread
            if (customerChoice == "3b")
            {
                Console.WriteLine("Would you like to add a drink? (Y/N)");
                string adding = Console.ReadLine();
                if (adding == "Y" || adding == "y")
                {
                    Console.WriteLine("Drink options: Fruit Juice(F) $1, soda(S) $2, coffee(C) $4, tea(T) $2");
                    string drink = Console.ReadLine();

                    if (drink == "F" || drink == "f")
                    {
                        int newPrice = (int)(1 + breadDeal.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "S" || drink == "s")
                    {
                        int newPrice = (int)(2 + breadDeal.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "C" || drink == "c")
                    {
                        int newPrice = (int)(4 + breadDeal.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "T" || drink == "t")
                    {
                        int newPrice = (int)(2 + breadDeal.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                }
                else
                {
                   Console.WriteLine("your total for " + breadDeal.Offer + " is $" + breadDeal.Price);
                    System.Environment.Exit(1);    
                }
            }

            // one pastry for $2
            if (customerChoice == "p")
            {
                Console.WriteLine("Would you like to add a drink? (Y/N)");
                string adding = Console.ReadLine();
                if (adding == "Y" || adding == "y")
                {
                    Console.WriteLine("Drink options: Fruit Juice(F) $1, soda(S) $2, coffee(C) $4, tea(T) $2");
                    string drink = Console.ReadLine();

                    if (drink == "F" || drink == "f")
                    {
                        int newPrice = (int)(1 + singlePastry.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "S" || drink == "s")
                    {
                        int newPrice = (int)(2 + singlePastry.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "C" || drink == "c")
                    {
                        int newPrice = (int)(4 + singlePastry.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "T" || drink == "t")
                    {
                        int newPrice = (int)(2 + singlePastry.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                }
                else
                {
                   Console.WriteLine("your total for " + singlePastry.Offer + " is $" + singlePastry.Price);
                    System.Environment.Exit(1);    
                }
            }
            
            // 3 patries for $5
            if (customerChoice == "3p")
            {
                Console.WriteLine("Would you like to add a drink? (Y/N)");
                string adding = Console.ReadLine();
                if (adding == "Y" || adding == "y")
                {
                    Console.WriteLine("Drink options: Fruit Juice(F) $1, soda(S) $2, coffee(C) $4, tea(T) $2");
                    string drink = Console.ReadLine();

                    if (drink == "F" || drink == "f")
                    {
                        int newPrice = (int)(1 + threePastries.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "S" || drink == "s")
                    {
                        int newPrice = (int)(2 + threePastries.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "C" || drink == "c")
                    {
                        int newPrice = (int)(4 + threePastries.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                    if (drink == "T" || drink == "t")
                    {
                        int newPrice = (int)(2 + threePastries.Price);
                        Console.WriteLine("your total is $" + newPrice);
                    }
                }
                else
                {
                   Console.WriteLine("your total for " + threePastries.Offer + " is $" + threePastries.Price);
                    System.Environment.Exit(1);    
                }
            }
        }
    }
}