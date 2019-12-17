using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;
// using System; // Add this if you want to use Console.WriteLine() in test method.
// using System.Collections.Generic;

namespace CoinCombination.Tests
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
    }
}