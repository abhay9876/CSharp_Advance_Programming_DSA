/*Recursive vs Iterative Fibonacci Computation
Objective
Compare Recursive (O(2^N)) vs Iterative (O(N)) Fibonacci solutions.
Approach
Recursive:
public static int FibonacciRecursive(int n) {
if (n <= 1) return n;
return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}
Iterative:

Fibonacci (N) Recursive (O(2^N)) Iterative (O(N))
10 1ms 0.01ms
30 5s 0.05ms
50 Unfeasible (>1hr) 0.1ms
Expected Result

Recursive approach is infeasible for large values of N due to exponential growth. The
iterative approach is significantly faster and memory-efficient.*/

using System;
using System.Diagnostics;

public class Fibonacci
{
	public static void  Calculate()
	{
        int[] nums = { 10, 30, 50 };
        for(int i = 0; i < 3; i++)
        {
            int n = nums[i];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int fab1 = FibonacciIterative(n);
            Console.WriteLine($"Iterative {n} : {fab1}");
            sw.Stop();
            Console.WriteLine($"Iterative Time: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            int fab2 = FibonacciRecursive(n);
            Console.WriteLine($"Recursive {n} : {fab2}");
            sw.Stop();
            Console.WriteLine($"Recursive Time: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine("----------------------------------------------");


        }
    }
    public static int FibonacciIterative(int n)
    {
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    public static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

    }
}
