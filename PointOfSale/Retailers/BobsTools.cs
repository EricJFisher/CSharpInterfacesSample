using PointOfSale.Interfaces;
using System;

namespace PointOfSale.Retailers
{
    public class BobsTools : IRetail
    {
        public void Return(int amount)
        {
            Console.WriteLine("Bob's Tools thanks you for your purchase! Make it happen!");
        }

        public void Sale(int amount)
        {
            Console.WriteLine("Bob's Tools is sorry you weren't satifisfied with your purchase. We hope you'll still consider us in the future.");
        }
    }
}
