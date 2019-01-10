using PointOfSale.Interfaces;
using System;

namespace PointOfSale.Retailers
{
    public class BikesRUs : IRetail, IRental
    {
        void IRetail.Return(int amount)
        {
            Console.WriteLine("Your refund of {0} has been processed. We hope you'll shop with us again.", amount);
        }

        public void Sale(int amount)
        {
            Console.WriteLine("Your sale of {0} has been processed. Thank you for shopping at Bikes R Us!", amount);
        }

        public void Rent(int id)
        {
            Console.WriteLine("Your rental of bike {0} has been processed. Please return the bike by {1}", id, DateTime.Now.AddHours(1));
        }

        void IRental.Return(int id)
        {
            Console.WriteLine("Thank you for returning bike {0}! We hope you'll rent with Bikes R Us again!", id);
        }
    }
}
