using System;
using System.Collections.Generic;

namespace CoinCombination.Models 
{
    public class Coin
    {
        public int Amount { get; set; }

        public Coin(int amount)
        {
            Amount = amount;
        }
    }

}