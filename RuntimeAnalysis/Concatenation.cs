/*String Concatenation Performance
Objective
Compare the performance of string (O(N2)), StringBuilder (O(N)), and StringBuffer (O(N))
when concatenating a million strings.
Approach
● Using string (Immutable, creates a new object each time)
● Using StringBuilder (Fast, mutable, thread-unsafe)
Operations Count (N) string (O(N2)) StringBuilder (O(N))
1,000 10ms 1ms
10,000 1s 10ms
1,000,000 30m (Unusable) 50ms
Expected Result
StringBuilder is much more efficient than string for concatenation.*/


using System;
using System.Diagnostics;
using System.Text;

public class Concatenation
{
	public static void  Concatenate()
	{
        int[] nums = { 1000, 10000 };
        for (int i = 0; i < nums.Length; i++)
        {
            Stopwatch sw = new Stopwatch();
            int n = nums[i];

            sw.Start();
            string s = "";
            for (int j = 0; j < n; j++)
            {
                s += "a";
            }
            sw.Stop();
            Console.WriteLine($"String for {n}: {sw.ElapsedMilliseconds}");


            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < n; j++)
            {
                sb.Append("b");
            }
            sw.Stop();
            Console.WriteLine($"StringBuilder for {n} : {sw.ElapsedMilliseconds}");
        }
    }
}
