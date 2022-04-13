using System;

namespace shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much gold do you have?");
            int gold = Convert.ToInt32(Console.ReadLine());
            int crystals = 30;
            int canBuyCrystals = gold / crystals;
            Console.WriteLine("You can buy {0} cristal.\nEnter the number of crystals you want to buy ", canBuyCrystals);
            int buyCristals = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Remains gold {0} \nRemains crystals {1}", gold - buyCristals * crystals, buyCristals);
        }
    }
}
