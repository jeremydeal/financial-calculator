using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinancialCalculator
{
    public static class Calculator
    {
        #region Declarations

        private static decimal _fv = 0m,
            _pv = 0m,
            _rate = 0m,
            _pmt = 0m;

        // # of compounds
        private static int _nper = 0,
            _compoundingPeriods = 1;

        #endregion

        #region Properties

        public static decimal Fv
        {
            get { return _fv; }
            set { _fv = value; }
        }

        public static decimal Pv
        {
            get { return _pv; }
            set { _pv = value; }
        }

        public static decimal Rate
        {
            get { return _rate / _compoundingPeriods; }
            set { _rate = value / 100; }
        }

        public static decimal Pmt
        {
            get { return _pmt; }
            set { _pmt = value; }
        }

        public static int Nper
        {
            get { return _nper * _compoundingPeriods; }
            set { _nper = value; }
        }

        public static int CompoundingPeriods
        {
            get { return _compoundingPeriods; }
            set { _compoundingPeriods = value; }
        }
        #endregion

        #region Initialize

        public static void Initialize()
        {
            // reset all values to 0
            _fv = 0m;
            _pv = 0m;
            _rate = 0m;
            _pmt = 0m;
            _nper = 0;
            _compoundingPeriods = 1;
        }
        #endregion

        #region Calculation Methods

        public static void CalculatePv()
        {
            // if just calculating interest...
            if (Pmt == 0)
            {
                Pv = -Fv / (decimal)Math.Pow((double)(1 + Rate), Nper);
            }
            // if calculating an annuity...
            else
            {
                // future value will not be used, so clear it
                Fv = 0;

                Pv = -Pmt * ((1 - ((decimal)Math.Pow((double)(1 / (1 + Rate)), Nper))) / Rate);
            }
        }

        public static void CalculateFv()
        {
            // if just calculating interest...
            if (Pmt == 0)
            {
                // calculate Fv
            }
            // if calculating an annuity...
            else
            {
                // present value will not be used, so clear it
                Pv = 0;

                // calculate Fv
            }
        }

        public static void CalculateNper()
        {
            // if just calculating interest...
            if (Pmt == 0)
            {
                // calculate Nper
            }
            // if calculating an annuity...
            else
            {
                // check whether Pv or Fv is given????

                // calculate Nper
            }
        }

        public static void CalculateRate()
        {
            // if just calculating interest...
            if (Pmt == 0)
            {
                // calculate Rate
            }
            // if calculating an annuity...
            else
            {
                // check whether Pv or Fv is given????

                // calculate Rate
            }
        }

        public static void CalculatePmt()
        {
            
        }

        #endregion

        #region Helper Methods

        #endregion
    }
}
