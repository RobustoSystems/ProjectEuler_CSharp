using System;
namespace ProjectEulerUtilities
{
    public static class NumericUtils
    {
        #region Static Methods
        public static bool IsXDivisibleByY(int x, int y)
        {
            if (x%y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        #endregion

    }
}