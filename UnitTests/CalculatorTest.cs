using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialCalculator;

namespace UnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [TestCategory("PV")]
        public void CalcPvFromSum()
        {
            Calculator.Initialize();
            Calculator.Fv = -10000;
            Calculator.Rate = 6;
            Calculator.Nper = 10;

            Calculator.CalculatePv();

            Assert.AreEqual(5583.95m, Math.Round(Calculator.Pv, 2));
        }

        [TestMethod]
        [TestCategory("PV")]
        public void CalcPvFromSumMonthly()
        {
            Calculator.Initialize();
            Calculator.CompoundingPeriods = 12;
            Calculator.Fv = -10000;
            Calculator.Rate = 6;
            Calculator.Nper = 10;

            Calculator.CalculatePv();

            Assert.AreEqual(5496.33m, Math.Round(Calculator.Pv, 2));
        }

        [TestMethod]
        [TestCategory("PV")]
        public void CalcPvFromAnnuity()
        {
            Calculator.Initialize();
            Calculator.Rate = 6;
            Calculator.Nper = 10;
            Calculator.Pmt = -1000;

            Calculator.CalculatePv();

            Assert.AreEqual(7360.09m, Math.Round(Calculator.Pv, 2));
        }

        [TestMethod]
        [TestCategory("PV")]
        public void CalcPvFromAnnuityMonthly()
        {
            Calculator.Initialize();
            Calculator.CompoundingPeriods = 12;
            Calculator.Rate = 6;
            Calculator.Nper = 10;
            Calculator.Pmt = -100;

            Calculator.CalculatePv();

            Assert.AreEqual(9007.35m, Math.Round(Calculator.Pv, 2));
        }

    }
}
