using System;

namespace Bakery.Models
{
    public class Bread
    {
        public string Offer {get; set;}
        public int Price {get; set;}
        public void GetDetails(string customerChoice)
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
}