/*Compare StringBuilder Performance
Problem: Write a program that compares the performance of StringBuilder for
concatenating strings multiple times.   */


using System;
using System.Diagnostics;
using System.Text;

public class Compare
{
	public static void Class1()
	{
		Stopwatch sw = new Stopwatch();
		int n = 100000;
		
		sw.Start();
        string s = "";
        for (int i = 0; i < n; i++)
		{
			s += "a";
		}
		sw.Stop();
		Console.WriteLine($"String : {sw.ElapsedMilliseconds}");

		
		sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
			sb.Append("b");
        }
        sw.Stop();
        Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}");
    }
}
