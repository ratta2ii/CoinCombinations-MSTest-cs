using System;
//using System.Collections.Generic;


namespace CoinCombinations.Models
{
    public class Program
    {
        static void Main()
        {
            
            int userInput = isNumberEntry();


            Coin newCoin = new Coin(userInput);
            newCoin.CountCoins();
            Console.WriteLine(newCoin.DisplayResults());

        }

        public static int isNumberEntry()
        {
            int number = 0;
            Console.WriteLine("Enter an amount of cents.");
            bool userInput = Int32.TryParse(Console.ReadLine(), out number);

            if (!userInput || number < 0 || number > 1000000)
            {
                Console.WriteLine("Please enter a number between 1 and a million!");
                number = 0;
                return isNumberEntry();
            }
            return number;
        }
    }  
}

