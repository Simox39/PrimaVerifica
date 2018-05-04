using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSomma()
        {
            double num1 = 3;
            double num2 = 7;
            double ris = 10;

            double somma = Calc.Somma(num1, num2);
            Assert.AreEqual(ris, somma);

        }
        [TestMethod]
        public void TestSottrazione()
        {
            double num1 = 20;
            double num2 = 13;
            double ris = 7;

            double sottrazione = Calc.Sottrazione(num1, num2);
            Assert.AreEqual(ris, sottrazione);

        }
        [TestMethod]
        public void TestMoltiplicazione()
        {
            double num1 = 3;
            double num2 = 9;
            double ris = 27;

            double moltiplicazione = Calc.Moltiplicazione(num1, num2);
            Assert.AreEqual(ris, moltiplicazione);

        }
        [TestMethod]
        public void TestDivisione()
        {
            double num1 = 6;
            double num2 = 3;
            double ris = 2;

            double divisione = Calc.Divisione(num1, num2);
            Assert.AreEqual(ris, divisione);

        }
        [TestMethod]
        public void TestMassimo()
        {
            double num1 = 3;
            double num2 = 7;
            double ris = 7;

            double massimo = Calc.Massimo(num1, num2);
            Assert.AreEqual(ris, massimo);

        }
        [TestMethod]
        public void TestMinimo()
        {
            double num1 = 9;
            double num2 = 55;
            double ris = 9;

            double minimo = Calc.Minimo(num1, num2);
            Assert.AreEqual(ris, minimo);

        }

        [TestMethod]
        public void TestRaddoppio()
        {
            int[] v1 = new int[] { 6, 7, 8, 9 };
            int[] v2 = new int[] { 12, 14, 16, 18 };


           int[] VettoreDoppio = Calc.RaddoppiaContenuto(v1);
            CollectionAssert.AreEqual(VettoreDoppio, v2);

        }

    }
}
