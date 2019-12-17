using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations.Models;
// using System; // Add this if you want to use Console.WriteLine() in test method.
// using System.Collections.Generic;

namespace CoinCombinations.Tests
{
    [TestClass]
    public class CoinTest
    {
        [TestMethod]
        public void CoinConstructor_CreateInstanceOfCoin_Coin()
        {
            Coin coinTest = new Coin(50);
            Assert.AreEqual(typeof(Coin), coinTest.GetType());
        }


        [TestMethod]
        public void CoinConstructor_SetPropertyTypeCoin_99()
        {
            Coin coinTest2 = new Coin(99);
            Assert.AreEqual(99, coinTest2.Amount);
        }


        [TestMethod]
        public void CountCoins_IncrementQuarterCounter_1()
        {
            Coin coinTest3 = new Coin(25);
            coinTest3.CountCoins();
            Assert.AreEqual(1, coinTest3.Quarter);
        }


        [TestMethod]
        public void CountCoins_IncrementDimeCounter_2()
        {
            Coin coinTest4 = new Coin(20);
            coinTest4.CountCoins();
            Assert.AreEqual(2, coinTest4.Dime);
        }


        [TestMethod]
        public void CountCoins_IncrementNickleCounter_1()
        {
            Coin coinTest5 = new Coin(5);
            coinTest5.CountCoins();
            Assert.AreEqual(1, coinTest5.Nickle);
        }


        [TestMethod]
        public void CountCoins_IncrementPennyCounter_4()
        {
            Coin coinTest6 = new Coin(4);
            coinTest6.CountCoins();
            Assert.AreEqual(4, coinTest6.Penny);
        }


         [TestMethod]
        public void DisplayResults_ReturnAllCounters_String()
        {
            Coin coinTest7 = new Coin(99);
            coinTest7.CountCoins();
            Assert.AreEqual("Quarters: 3 Dimes: 2 Nickles: 0 Pennies: 4", coinTest7.DisplayResults());
        }
    }
}