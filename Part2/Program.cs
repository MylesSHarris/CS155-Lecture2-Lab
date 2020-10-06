using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int coupons = 78;

            int candybars = coupons / 10;
            int gumballs  = coupons % 10 / 3;

            Console.WriteLine("You redeem " + coupons + " total coupons.");
            Console.WriteLine(candybars + " candybars and " + gumballs + " gumballs.");
        }
    }
}
