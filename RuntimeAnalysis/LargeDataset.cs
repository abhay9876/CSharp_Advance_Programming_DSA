/*1. Search a Target in a Large Dataset
Objective
Compare the performance of Linear Search (O(N)) and Binary Search (O(log N)) on different
dataset sizes.
Approach
● Linear Search: Scan each element until the target is found.
● Binary Search: Sort the data first (O(N log N)), then perform O(log N) search.
Dataset Size(N)   Linear Search (O(N))    Binary Search (O(log N))
	10,000				10ms					0.02ms
Expected Result
Binary Search performs much better for large datasets, provided data is sorted. */

using System;
using System.Diagnostics;

public class LargeDataset
{
	public static void  Data()
	{
        int arr = 10000;
		int target = arr - 1;

        // Linear Search
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < arr; i++)
        {
            if ( i == target)
            {
                Console.WriteLine("Found..");
            }
                
        }
        sw.Stop();
        Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");


        // Binary Serch
        sw.Restart();
        int left = 0, right = arr-1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (mid == target)
            {
                Console.WriteLine("Found.. Binary Search");
                break;
            }
                
            else if (mid < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        sw.Stop();
        Console.WriteLine($"Binary Search Time: {sw.ElapsedMilliseconds} ms");

    }
}




