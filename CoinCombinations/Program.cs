using System;
using System.Collections.Generic;


namespace CoinCombination.Models
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an amount of cents.");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);
            Coin newCoin = new Coin(userInput);
        }
    }
}

