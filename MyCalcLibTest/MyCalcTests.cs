using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;
using System;

namespace MyCalcLibTest
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int x = 10;
            int y = 20;
            int expected = 30;
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Vich_20and10_10returned()
        {
            int x = 20;
            int y = 10;
            int expected = 10;
            MyCalc c = new MyCalc();
            int actual = c.Vich(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Umn_20and10_200returned()
        {
            int x = 20;
            int y = 10;
            int expected = 200;
            MyCalc c = new MyCalc();
            int actual = c.Umn(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Del_20and10_2returned()
        {
            int x = 20;
            int y = 10;
            int expected = 2;
            MyCalc c = new MyCalc();
            int actual = c.Del(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
