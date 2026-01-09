/*Problem 1: Concatenate Strings Efficiently Using StringBuilder
Problem: You are given an array of strings. Write a program that uses StringBuilder to
concatenate all the strings in the array efficiently.*/

using System;
using System.Text;

public class Concatenate
{
	public static void Class1()
	{
		Console.WriteLine("Enter the size of array : ");
		int n = int.Parse(Console.ReadLine());
		string[] arr = new string[n];
		for(int i = 0; i < n; i++)
		{
			arr[i] = Console.ReadLine();
		}

		StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
			sb.Append(arr[i]);
        }

		Console.WriteLine("Concatenate : " + sb.ToString());
    }
}
