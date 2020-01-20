using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestaiU;

namespace TestaiU.test
{
    [TestClass]
    public class TaskTest
    {
        [TestMethod]
        public void TaskTuretuButSiektiekDaugiaunei40000()
        {
            //Arange
            mokesciai m = new mokesciai();
            //act
            decimal result = m.tax(40000);
            //Asset
            Assert.AreEqual(result, 2000);
        }

        [TestMethod]
        public void TaskTuretuButSiektiekDaugiaunei0000()
        {
            //Arange
            mokesciai m = new mokesciai();
            //act
            decimal result = m.tax(50000);
            //Asset
            Assert.AreEqual(result, 7500);
        }

        [TestMethod]
        public void TaskTuretuButSiektiekDaugiauneivirs1000()
        {
            //Arange
            mokesciai m = new mokesciai();
            //act
            decimal result = m.tax(110000);
            //Asset
            Assert.AreEqual(result, 27500);
        }

        [TestMethod]
        public void Ta000000000000000()
        {
            //Arange
            mokesciai m = new mokesciai();
            //act
            decimal result = m.tax(0);
            //Asset
            Assert.AreEqual(result, 0);
        }


    }
}
