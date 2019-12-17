using System;
//using System.Collections.Generic;


namespace CoinCombinations.Models
{
    public class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Enter an amount of cents.");
            int userInput = int.Parse(Console.ReadLine());
            Coin newCoin = new Coin(userInput);
            newCoin.CountCoins();
            Console.WriteLine(newCoin.DisplayResults());

        }
    }
}

