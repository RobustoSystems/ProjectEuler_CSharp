using System;
namespace ProjectEulerUtilities
{
    public static class NumericUtils
    {
        #region Public Methods
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

        public static List<FactorStruct> GetPrimeFactors(ulong x)
        {
            List<FactorStruct> primeFactors = new List<FactorStruct>();

            if (x == 0)
            {
                primeFactors.Add(new FactorStruct(0,1)); // Let this be a convention. Return a factor of 0 for input x 0.
            }
            else if (x == 1)
            {
                primeFactors.Add(new FactorStruct(1, 1));
            }
            else // x >= 2
            {
                ulong numberUnderTest = x;
                bool hasNumberBeenReducedToAPrime = false;
                while (hasNumberBeenReducedToAPrime == false)
                {
                    (bool isPrime, ulong firstFactor) = IsPrimeVersion1(numberUnderTest);
                    (bool isExistingFactor, int listIndex) = SearchFactorsList(primeFactors, firstFactor);
                    if (isExistingFactor)
                    {
                        primeFactors[listIndex] = new FactorStruct(primeFactors[listIndex].Factor, primeFactors[listIndex].Power + 1); // increment the power
                    }
                    else
                    {
                        primeFactors.Add(new FactorStruct(firstFactor,1));
                    }

                    if (isPrime)
                    {
                        hasNumberBeenReducedToAPrime = true;
                    }
                    else
                    {
                        numberUnderTest = numberUnderTest / firstFactor;
                    }
                }
            }
            return primeFactors;
        }       

        /// <summary>
        /// This method returns a tuple: The bool is True if and only if x is prime; The ulong is the value of the smallest factor (except 1). For a prime number the smallest factor is the number itself.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static (bool, ulong) IsPrimeVersion1(ulong x)
        {
            bool isPrime = false;
            ulong smallestFactor = 0;

            if ((x == 0) || (x == 1))
            {
                isPrime = false;
                smallestFactor = x;
            }
            else if (((x == 2) || (x == 3)))
            {
                isPrime = true;
                smallestFactor = x;
            }
            else // x >= 4
            {
                ulong loopIteration = 0;
                bool hasFactorBeenFound = false;
                while (hasFactorBeenFound == false)
                {
                    if (loopIteration == 0)
                    {
                        // Special case: the first iteration
                        if (x % 2 == 0)
                        {
                            isPrime = false;
                            smallestFactor = 2;
                            hasFactorBeenFound = true;
                        }
                    }
                    else
                    {
                        // Main branch. Not the first iteration.
                        ulong potentialFactor = (loopIteration * 2) + 1; // try odd factors, such as 3, 5, 7, 9, ...
                        ulong potentialFactorSquared = potentialFactor * potentialFactor;
                        if (potentialFactorSquared > x)
                        {
                            isPrime = true;
                            smallestFactor = x;
                            hasFactorBeenFound = true;
                        }
                        else if (potentialFactorSquared == x)
                        {
                            isPrime = false;
                            smallestFactor = potentialFactor;
                            hasFactorBeenFound = true;
                        }
                        else
                        {
                            if (x % potentialFactor == 0)
                            {
                                isPrime = false;
                                smallestFactor = potentialFactor;
                                hasFactorBeenFound = true;
                            }
                        }
                    }
                    loopIteration++;
                }
            }

            return (isPrime, smallestFactor);
        }

        public static void PrintFactors(List<FactorStruct> factors)
        {
            if (factors.Count == 0)
            {
                Console.WriteLine("The factors list is empty.");
            }
            else
            {
                int factorCounter = 1;
                foreach (FactorStruct factorStruct in factors)
                {
                    Console.WriteLine($"{factorCounter}. Factor = {factorStruct.Factor}, Power = {factorStruct.Power}");
                }
            }
        }
        
        #endregion // end of Public Methods

        #region Private Methods
        private static (bool, int) SearchFactorsList(List<FactorStruct> factorList, ulong factor)
        {
            bool isExistingFactor = false;
            int listIndex = -1;

            if (factorList.Count > 0)
            {
                int loopIteration = 0;
                foreach (FactorStruct existingFactor in factorList)
                {
                    if (factor == existingFactor.Factor)
                    {
                        // This is a new power of an already existent factor
                        isExistingFactor = true;
                        listIndex = loopIteration;
                        break;
                    }
                    loopIteration++;
                }
            }
            return (isExistingFactor, listIndex);
        }
        #endregion // end of Private Methods

    }

    public struct FactorStruct
    {
        public ulong Factor { get; }

        public ulong Power { get; }

        public FactorStruct(ulong factor, ulong power)
        {
            this.Factor = factor;
            this.Power = power;
        }
    }
}