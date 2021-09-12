using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitProblem.Utilities
{
    public static class StringExtensions
    {
        #region Public Methods

        public static int ToInt(this string value)
        {
            int retVal = 0;
            Int32.TryParse(value, out retVal);

            return retVal;
        }

        public static bool IsNumeric(this string value)
        {
            int converted = 0;
            bool retVal = int.TryParse(value, out converted);

            return retVal;
        }

        #endregion
    }
}
