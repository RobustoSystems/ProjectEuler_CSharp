using ProjectEulerUtilities;
using System.Diagnostics;

#region Calling the Methods
// Uncomment the calls to the method(s) you want to execute
//Problem1();
//Problem2();
Problem3();

#region Testing utility methods

#region Testing GetFactors
//ulong x;
//x = 0;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 1;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 2;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 3;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 4;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 5;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 6;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 7;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 8;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 9;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 10;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 100;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
//x = 10000;
//Console.WriteLine($"x = {x}:");
//NumericUtils.PrintFactors(NumericUtils.GetPrimeFactors(x));
#endregion

#region Testing IsPrimeVersion1
//bool isPrime;
//ulong smallestFactor;
//ulong x = 0;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 1;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 2;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 3;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 4;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 5;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 6;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 7;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 11;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 13;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 15;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = 147;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
//x = (ulong)int.MaxValue;
//(isPrime, smallestFactor) = NumericUtils.IsPrimeVersion1(x);
//Console.WriteLine($"x = {x}, isPrime = {isPrime}, smallestFactor = {smallestFactor}");
#endregion

#endregion
#endregion

#region Method Definitions
static void ProblemTemplate()
{
    // Copy the problem text here.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine("Problem n");
    int answer = 0;

    // 
    // add code here
    //

    Console.WriteLine($"Answer = {answer}");
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem1()
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine("Problem 1");
    int sum = 0;
    for (int i = 1; i <= 1000; i++)
    {
        if (NumericUtils.IsXDivisibleByY(i,3))
        {
            sum += i;
        }
        else if (NumericUtils.IsXDivisibleByY(i, 5))
        {
            sum += i;
        }
    }
    Console.WriteLine($"Answer = {sum}");
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem2()
{
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine("Problem 2");
    ulong answer = 0;

    List<ulong> fibonacciTerms = NumericUtils.GetFibonacciSeries(4000000);
    foreach (ulong fibonacciTerm in fibonacciTerms)
    {
        if (fibonacciTerm % 2 == 0)
        {
            answer += fibonacciTerm;
        }
    }

    Console.WriteLine($"Answer = {answer}");
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem3()
{
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine("Problem 3");
    
    List<FactorStruct> primeFactors = NumericUtils.GetPrimeFactors(600851475143);

    ulong largestPrimeFactor = 0;
    foreach (FactorStruct primeFactor in primeFactors)
    {
        if (primeFactor.Factor > largestPrimeFactor)
        {
            largestPrimeFactor = primeFactor.Factor;
        }
    }

    Console.WriteLine($"Answer = {largestPrimeFactor}");
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}
#endregion