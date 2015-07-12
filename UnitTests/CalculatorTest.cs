using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialCalculator;

namespace UnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [TestCategory("Pv")]
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
        [TestCategory("Pv")]
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
        [TestCategory("Pv")]
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
        [TestCategory("Pv")]
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

        [TestMethod]
        [TestCategory("Fv")]
        public void CalcFvFromSum()
        {
            Calculator.Initialize();
            Calculator.Pv = -10000;
            Calculator.Rate = 6;
            Calculator.Nper = 10;

            Calculator.CalculateFv();

            Assert.AreEqual(17908.48m, Math.Round(Calculator.Fv, 2));
        }

        [TestMethod]
        [TestCategory("Fv")]
        public void CalcFvFromSumMonthly()
        {
            Calculator.Initialize();
            Calculator.CompoundingPeriods = 12;
            Calculator.Pv = -10000;
            Calculator.Rate = 6;
            Calculator.Nper = 10;

            Calculator.CalculateFv();

            Assert.AreEqual(18193.97m, Math.Round(Calculator.Fv, 2));
        }

        [TestMethod]
        [TestCategory("Fv")]
        public void CalcFvFromAnnuity()
        {
            Calculator.Initialize();
            Calculator.Rate = 6;
            Calculator.Nper = 10;
            Calculator.Pmt = -1000;

            Calculator.CalculateFv();

            Assert.AreEqual(13180.79m, Math.Round(Calculator.Fv, 2));
        }

        [TestMethod]
        [TestCategory("Fv")]
        public void CalcFvFromAnnuityMonthly()
        {
            Calculator.Initialize();
            Calculator.CompoundingPeriods = 12;
            Calculator.Rate = 6;
            Calculator.Nper = 10;
            Calculator.Pmt = -100;

            Calculator.CalculateFv();

            Assert.AreEqual(16387.93m, Math.Round(Calculator.Fv, 2));
        }


    }
}
