using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCalculator
{
    /// <summary>
    /// Handles exceptions from within the Calculator class' formulas.
    /// Also tracks which inputs are required for a given formula.
    /// </summary>
    public static class ErrorManager
    {
        public static string Message = "";
        public enum Inputs { Fv, Pv, Rate, Nper, Pmt }     // TODO: add EFFECT inputs
        public static List<Inputs> RequiredInputs = new List<Inputs>();
        public static List<Inputs> MutuallyExclusiveInputs = new List<Inputs>();

        #region Required Value Notifier

        #endregion


        #region Exceptions

        #endregion
    }
}
