using ProjectEulerUtilities;
using System.Diagnostics;

#region Calling the Methods
// Uncomment the calls to the method(s) you want to execute
//Problem1();
//Problem2();
//Problem3();
//Problem4();
//Problem5();
//Problem6();
//Problem7();
//Problem8();
//Problem9();
Problem10();

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

#region Testing IsPalindrome
//ulong x;
//x = 0;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 1;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 2;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 9;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 10;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 11;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 12;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 100;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 110;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 111;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 112;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 100001;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
//x = 987789;
//Console.WriteLine($"x = {x}, isPalindrome = {NumericUtils.IsPalindrome(x)}");
#endregion

#region Testing GetLeastCommonMultiple
//ulong x, y;
//x = 2;
//y = 3;
//Console.WriteLine($"x = {x}, y = {y}, LCM = {NumericUtils.GetLeastCommonMultiple(x, y)}"); // expected: LCM = 6
//x = 3;
//y = 5;
//Console.WriteLine($"x = {x}, y = {y}, LCM = {NumericUtils.GetLeastCommonMultiple(x, y)}"); // expected: LCM = 15
//x = 5;
//y = 10;
//Console.WriteLine($"x = {x}, y = {y}, LCM = {NumericUtils.GetLeastCommonMultiple(x, y)}"); // expected: LCM = 10
//x = 100;
//y = 200;
//Console.WriteLine($"x = {x}, y = {y}, LCM = {NumericUtils.GetLeastCommonMultiple(x, y)}"); // expected: LCM = 200
//x = 100;
//y = 3;
//Console.WriteLine($"x = {x}, y = {y}, LCM = {NumericUtils.GetLeastCommonMultiple(x, y)}"); // expected: LCM = 300
//x = 1245;
//y = 569823;
//Console.WriteLine($"x = {x}, y = {y}, LCM = {NumericUtils.GetLeastCommonMultiple(x, y)}"); // expected: LCM = 236,476,545
#endregion

#region Testing GetLeastCommonMultipleListInput
//List<ulong> inputIntegers;
//inputIntegers = new List<ulong> { 2, 3};
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 6
//inputIntegers = new List<ulong> { 3, 5 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 15
//inputIntegers = new List<ulong> { 5, 10 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 10
//inputIntegers = new List<ulong> { 100, 200 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 200
//inputIntegers = new List<ulong> { 100, 3 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 300
//inputIntegers = new List<ulong> { 1245, 569823 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 236,476,545
//inputIntegers = new List<ulong> { 2, 3, 100 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 300
//inputIntegers = new List<ulong> { 1, 1, 1 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 1
//inputIntegers = new List<ulong> { 17, 3, 5 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 255
//inputIntegers = new List<ulong> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine($"LCM = {NumericUtils.GetLeastCommonMultipleListInput(inputIntegers)}"); // expected: LCM = 2520
#endregion

#endregion
#endregion

#region Method Definitions
static void Problem10()
{
    // https://projecteuler.net/problem=10
    // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    // Find the sum of all the primes below two million.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem10)}");
    ulong answer = 0;

    ulong sumOfPrimes = 0;
    for (ulong i = 2; i <= 2000000; i++)
    {
        (bool isPrime, _) = NumericUtils.IsPrime(i);
        if (isPrime)
        {
            sumOfPrimes += i;
        }
    }

    answer = sumOfPrimes;
    Console.WriteLine($"Answer = {answer}"); // Answer = 142,913,828,922; Execution time = 1,009 ms
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem9()
{
    // https://projecteuler.net/problem=9
    // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which a^2 + b^2 = c^2
    // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.

    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem9)}");
    int answer = 0;
    int desiredTripletSum = 1000;
    bool tripletFound = false;
    for (int a = 1; a <= desiredTripletSum; a++) 
    // Enumerate the number a (the first of the triplet)
    {
        if (tripletFound)
        {
            break;
        }
        int b = 0;
        while (true)
        // Enumerate the number b, and find a suitable number c. Break out of the loop when triplet found, or when b is too large.
        {
            b++;
            if (a + b >= desiredTripletSum)
            {
                break; // We've already exceeded the desired sum. We can't find a c that would complete the triplet.
            }
            else
            {
                // attempt to find c
                int aPlusBSquared = (a * a) + (b * b);
                int roundedSqrtOfAPlusBSquared = Convert.ToInt32(Math.Round(Math.Sqrt(Convert.ToDouble(aPlusBSquared))));
                if (roundedSqrtOfAPlusBSquared * roundedSqrtOfAPlusBSquared == aPlusBSquared)
                {
                    // c was found
                    int c = roundedSqrtOfAPlusBSquared;
                    if ( (a + b + c) == desiredTripletSum)
                    {
                        // desired triplet was found
                        tripletFound = true;
                        answer = a * b * c;
                        Console.WriteLine("Desired triplet was found.");
                        Console.WriteLine($"a = {a}");
                        Console.WriteLine($"c = {c}");
                        Console.WriteLine($"b = {b}");
                        break;
                    }
                }
            }
        }
    }

    Console.WriteLine($"Answer = {answer}"); // Answer = 31875000; (a,b,c) = (200,375,425)
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem8()
{
    // https://projecteuler.net/problem=8
    // The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
    /*
        73167176531330624919225119674426574742355349194934
        96983520312774506326239578318016984801869478851843
        85861560789112949495459501737958331952853208805511
        12540698747158523863050715693290963295227443043557
        66896648950445244523161731856403098711121722383113
        62229893423380308135336276614282806444486645238749
        30358907296290491560440772390713810515859307960866
        70172427121883998797908792274921901699720888093776
        65727333001053367881220235421809751254540594752243
        52584907711670556013604839586446706324415722155397
        53697817977846174064955149290862569321978468622482
        83972241375657056057490261407972968652414535100474
        82166370484403199890008895243450658541227588666881
        16427171479924442928230863465674813919123162824586
        17866458359124566529476545682848912883142607690042
        24219022671055626321111109370544217506941658960408
        07198403850962455444362981230987879927244284909188
        84580156166097919133875499200524063689912560717606
        05886116467109405077541002256983155200055935729725
        71636269561882670428252483600823257530420752963450
     */
    // Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem8)}");
    ulong answer = 0;

    string inputNumberWithLineBreaks = @"
        73167176531330624919225119674426574742355349194934
        96983520312774506326239578318016984801869478851843
        85861560789112949495459501737958331952853208805511
        12540698747158523863050715693290963295227443043557
        66896648950445244523161731856403098711121722383113
        62229893423380308135336276614282806444486645238749
        30358907296290491560440772390713810515859307960866
        70172427121883998797908792274921901699720888093776
        65727333001053367881220235421809751254540594752243
        52584907711670556013604839586446706324415722155397
        53697817977846174064955149290862569321978468622482
        83972241375657056057490261407972968652414535100474
        82166370484403199890008895243450658541227588666881
        16427171479924442928230863465674813919123162824586
        17866458359124566529476545682848912883142607690042
        24219022671055626321111109370544217506941658960408
        07198403850962455444362981230987879927244284909188
        84580156166097919133875499200524063689912560717606
        05886116467109405077541002256983155200055935729725
        71636269561882670428252483600823257530420752963450
        ";

    string inputNumber = inputNumberWithLineBreaks.Trim();

    List<int> digits = new();
    foreach (char character in inputNumberWithLineBreaks)
    {
        if (('0' <= character) && (character <= '9'))
        {
            int digit = Convert.ToInt32(character) - 48; // The character '0' corresponds to decimal value 48
            digits.Add(digit);
        }
    }

    int numberOfAdjacentDigits = 13;
    int numberOfAdjacentDigitGroups = digits.Count - numberOfAdjacentDigits + 1;

    Console.WriteLine($"numberOfAdjacentDigitGroups = {numberOfAdjacentDigitGroups}");

    ulong maxProduct = 0;
    List<ulong> products = new();
    for (int i = 0; i < numberOfAdjacentDigitGroups; i++)
    {
        ulong product = 1;
        for (int j = i; j < i + numberOfAdjacentDigits; j++)
        {
            product *= Convert.ToUInt64(digits[j]);
            // Console.WriteLine($"product = {product}");
        }
        products.Add(product);
        if (product > maxProduct)
        {
            maxProduct = product;
        }
    }

    answer = maxProduct;
    Console.WriteLine($"Answer = {answer}"); // Answer = 23,514,624,000
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem7()
{
    // https://projecteuler.net/problem=7
    // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    // What is the 10 001st prime number?
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem7)}");
    ulong answer = 0;

    List<ulong> primes = new();
    for (ulong i = 2; i <= 1000000; i++)
    {
        (bool isPrime, _) = NumericUtils.IsPrime(i);
        if (isPrime)
        {
            primes.Add(i);
            if (primes.Count == 10001)
            {
                break;
            }
        }
    }
    answer = primes[10000];
    Console.WriteLine($"Answer = {answer}"); // Answer = 104743
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem6()
{
    // https://projecteuler.net/problem=6
    // The sum of the squares of the first ten natural numbers is 1^2 + 2^2 + ... + 10^2 = 385
    // The square of the sum of the first ten natural numbers is (1 + 2 + ... + 10) ^ 2 = 3025
    // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640
    // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem6)}");
    long answer = 0;

    long sum = 0;
    long sumOfSquares = 0;
    for (int i = 1; i <= 100; i++)
    {
        sum += i;
        sumOfSquares += i * i;
    }
    long squareOfSum = sum * sum;

    answer = squareOfSum - sumOfSquares;

    Console.WriteLine($"Answer = {answer}"); // Answer = 25164150
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem5()
{
    // https://projecteuler.net/problem=5
    // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem5)}");
    ulong answer = 0;

    answer = NumericUtils.GetLeastCommonMultipleListInput(new List<ulong> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

    Console.WriteLine($"Answer = {answer}"); // Answer = 232,792,560
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem4()
{
    // https://projecteuler.net/problem=4
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3 - digit numbers.

    // Solution design 1:
    // Three - digit numbers are 100 to 999(900 numbers).
    // Therefore, there are 900x900(900 ^ 2) numbers that are the product of two 3 - digit numbers.
    // 900 ^ 2 = 810,000 numbers. Generate these numbers and check each one if palindrome.Keep largest that is.

    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem4)}");
    ulong largestPalindromeProduct = 0;

    List<ulong> palindromeProducts = new List<ulong>();
    for (int i = 100; i <= 999; i++)
    {
        for (int j = 100; j <= 999; j++)
        {
            ulong productUnderTest = (ulong)i * (ulong)j;
            if (NumericUtils.IsPalindrome(productUnderTest))
            {
                palindromeProducts.Add(productUnderTest);
                if (productUnderTest > largestPalindromeProduct)
                {
                    largestPalindromeProduct = productUnderTest;
                }
            }
        }
    }

    Console.WriteLine($"Answer = {largestPalindromeProduct}"); // Answer = 906609
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem3()
{
    // https://projecteuler.net/problem=3
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem3)}");

    List<FactorStruct> primeFactors = NumericUtils.GetPrimeFactors(600851475143);

    ulong largestPrimeFactor = 0;
    foreach (FactorStruct primeFactor in primeFactors)
    {
        if (primeFactor.Factor > largestPrimeFactor)
        {
            largestPrimeFactor = primeFactor.Factor;
        }
    }

    Console.WriteLine($"Answer = {largestPrimeFactor}"); // Answer = 6857
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem2()
{
https://projecteuler.net/problem=2
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem2)}");
    ulong answer = 0;

    List<ulong> fibonacciTerms = NumericUtils.GetFibonacciSeries(4000000);
    foreach (ulong fibonacciTerm in fibonacciTerms)
    {
        if (fibonacciTerm % 2 == 0)
        {
            answer += fibonacciTerm;
        }
    }

    Console.WriteLine($"Answer = {answer}"); // Answer = 4613732
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void Problem1()
{
https://projecteuler.net/problem=1
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(Problem1)}");
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
    Console.WriteLine($"Answer = {sum}"); // Answer = 234168
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}

static void ProblemTemplate()
{
    // Copy the problem URL here
    // Copy the problem text here.
    Stopwatch executionTimer = Stopwatch.StartNew();
    Console.WriteLine($"{nameof(ProblemTemplate)}");
    int answer = 0;

    // 
    // add code here
    //

    Console.WriteLine($"Answer = {answer}"); // Answer = <copy value here>
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}
#endregion