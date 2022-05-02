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

        public static bool IsOdd(int x)
        {
            return (!IsXDivisibleByY(x, 2));
        }

        public static bool IsEven(int x)
        {
            return (IsXDivisibleByY(x, 2));
        }

        /// <summary>
        /// This method returns a list of the first n terms in the Fibonacci series.
        /// The last term in the return list is the last term whose value is <= maximumValue.
        /// Example 1: When this method is called with maximumValue = 10, it returns the list: 1, 2, 3, 5, 8
        /// Example 2: When this method is called with maximumValue = 100, it returns the list: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
        /// </summary>
        /// <param name="maximumValue"></param>
        /// <returns></returns>
        public static List<ulong> GetFibonacciSeries(ulong maximumValue)
        {
            const ulong firstFibonacciNumber = 1;
            const ulong secondFibonacciNumber = 2;

            List<ulong> fibonacciSeries = new List<ulong>();
            if (maximumValue == 0)
            {
                // do nothing; the method will return an empty list
            }
            else if (maximumValue == 1)
            {
                fibonacciSeries.Add(firstFibonacciNumber);
            }
            else if (maximumValue == 2)
            {
                fibonacciSeries.Add(firstFibonacciNumber);
                fibonacciSeries.Add(secondFibonacciNumber);
            }
            else
            {
                // This is the main branch. Expected to execute most of the time.
                fibonacciSeries.Add(firstFibonacciNumber);
                fibonacciSeries.Add(secondFibonacciNumber);
                ulong nextFibonacciNumber;
                int nextFibonacciTermPosition = 2; // Let the first position in the series be 0, the second position be 1, and so on.
                do
                {
                    nextFibonacciNumber = fibonacciSeries[nextFibonacciTermPosition - 1] + fibonacciSeries[nextFibonacciTermPosition - 2];
                    nextFibonacciTermPosition++;
                    if (nextFibonacciNumber <= maximumValue)
                    {
                        fibonacciSeries.Add(nextFibonacciNumber);
                    }
                } while (nextFibonacciNumber <= maximumValue);
            }

            return fibonacciSeries;
        }

        #endregion

    }
}