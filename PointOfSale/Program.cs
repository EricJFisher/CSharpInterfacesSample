using PointOfSale.Interfaces;
using PointOfSale.Retailers;
using System;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////////////////////////////");
            Console.WriteLine("/ Sample Inc Point of Sale System /");
            Console.WriteLine("///////////////////////////////////");
            Console.WriteLine();

            Console.WriteLine("What is the name of the retailer using this?");
            var name = Console.ReadLine();

            object retailer;

            switch(name.ToLower())
            {
                case "bobs tools":
                    retailer = new BobsTools();
                    break;
                case "bikes r us":
                    retailer = new BikesRUs();
                    break;
                default:
                    Console.WriteLine("Unknown retailer, exiting program.");
                    return;
            }
            Console.WriteLine();

            while(true)
            {
                Console.WriteLine("Welcome to Point of Sale System {0}!", name);
                if(retailer is IRetail)
                {
                    Console.WriteLine("To enter a sale type 'Sale 0' where '0' is the amount of the sale.");
                    Console.WriteLine("To enter a return of a sale type 'Refund 0' where '0' is the amount of the return.");
                }
                if(retailer is IRental)
                {
                    Console.WriteLine("To enter a rental type 'Rent 0' where '0' is the Id of the item being rented.");
                    Console.WriteLine("To enter a return of a rental item type 'Return 0' where '0' is the Id of the item being returned.");
                }
                Console.WriteLine();

                var transaction = Console.ReadLine().ToLower().Split(' ');
                switch (transaction[0])
                {
                    case "sale":
                        if (retailer is IRetail)
                        {
                            ((IRetail)retailer).Sale(int.Parse(transaction[1]));
                            break;
                        }
                           continue;
                    case "refund":
                        if (retailer is IRetail)
                        {
                            ((IRetail)retailer).Return(int.Parse(transaction[1]));
                            break;
                        }
                        continue;
                    case "rent":
                        if (retailer is IRental)
                        {
                            ((IRental)retailer).Return(int.Parse(transaction[1]));
                            break;
                        }
                        continue;
                    case "return":
                        if (retailer is IRental)
                        {
                            ((IRental)retailer).Return(int.Parse(transaction[1]));
                            break;
                        }
                        continue;
                    default:
                        Console.WriteLine("Unrecognized command, try again.");
                        break;
                }
            }
        }
    }
}
