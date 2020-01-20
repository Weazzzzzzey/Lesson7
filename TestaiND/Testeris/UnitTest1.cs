using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestaiND;

namespace Testeris
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ApverciaIlgaStringTeisingai()
        {
            //Arange
            Uzduotis uz1 = new Uzduotis();
            //act
            string result = uz1.Apvertimas("qwerty");
            //Asset
            Assert.AreEqual(result, "ytrewq");
        }

        [TestMethod]
        public void stringasIsVienoSimbolio()
        {
            //Arange
            Uzduotis uz1 = new Uzduotis();
            //act
            string result = uz1.Apvertimas("q");
            //Asset
            Assert.AreEqual(result, "q");
        }

        [TestMethod]
        public void stringasIsTuscioStringo()
        {
            //Arange
            Uzduotis uz1 = new Uzduotis();
            //act
            string result = uz1.Apvertimas("");
            //Asset
            Assert.AreEqual(result, "");
        }

        [TestMethod]
        public void ArGaunaTrueReiksmeSuLyginiu()
        {
            //Arange
            Uzduotis uz2 = new Uzduotis();
            //act
            bool result = uz2.lyginis(2);
            //Asset
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void ArGaunaFalseReiksmeSuNeLyginiu()
        {
            //Arange
            Uzduotis uz2 = new Uzduotis();
            //act
            bool result = uz2.lyginis(11);
            //Asset
            Assert.AreEqual(result, false);
        }

    }
}
