using ProjectEulerUtilities;
using System.Diagnostics;

Problem1();

static void Problem1()
{
    Stopwatch executionTimer = Stopwatch.StartNew();
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




// Problem template
static void ProblemN()
{
    Stopwatch executionTimer = Stopwatch.StartNew();
    int answer = 0;
    
    // 
    // add code here
    //
    
    Console.WriteLine($"Answer = {answer}");
    Console.WriteLine($"Execution time = {executionTimer.ElapsedMilliseconds} ms");
}