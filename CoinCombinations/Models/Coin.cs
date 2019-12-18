namespace CoinCombinations.Models 
{
    public class Coin
    {
        public int Amount { get; set; }
        public int Penny { get; set; }
        public int Nickel { get; set; }
        public int Dime { get; set; }
        public int Quarter { get; set; }

        public Coin(int amount)
        {
            Amount = amount;
            Penny = 0;
            Nickel = 0;
            Dime = 0;
            Quarter = 0;
        }
        public void CountCoins()
        {
          if (Amount >= 25)
          {
              Amount -= 25;
              Quarter++;
              CountCoins();
          } 
          else if (Amount >= 10)
          {
              Amount -= 10;
              Dime++;
              CountCoins();
          }
          else if (Amount >= 5)
          {
              Amount -= 5;
              Nickel++;
              CountCoins();
          }
          else 
          {
             Penny += Amount;
          }
        }
    }
}