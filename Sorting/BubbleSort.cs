/*Bubble Sort - Sort Student Marks
Problem Statement:
A school maintains student marks in an array. Implement Bubble Sort in C# to sort the
student marks in ascending order.
Hint:
● Traverse through the array multiple times.
● Compare adjacent elements and swap them if needed.
● Repeat the process until no swaps are required.*/



using System;

public class Bubble
{
	public static void Sort()
	{
		Console.WriteLine("Enter The Number of Students :");
		int n = int.Parse(Console.ReadLine());
		int[] marks = new int[n];
		for(int i = 0; i < n; i++)
		{
			marks[i] = int.Parse(Console.ReadLine());
		}

		for(int i = 0; i < n; i++)
		{
			bool swapped = false;
			for(int j = 0; j < n-i-1; j++)
			{
				if (marks[j] > marks[j+ 1])
				{
					int temp = marks[j];
					marks[j] = marks[j + 1];
					marks[j + 1] = temp;
					swapped = true;
				}
			}

			if (swapped == false)
			{
				break;
			}
		}

		Console.WriteLine(" Bubble Sort : ");
		for(int i= 0; i< marks.Length; i++)
		{
			Console.Write(" " + marks[i]);
		}
	}
}
