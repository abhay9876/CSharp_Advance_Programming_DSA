/*Linear Search Problem 1: Search for the First Negative Number
Problem: You are given an integer array. Write a program that performs Linear Search to find
the first negative number in the array.*/


using System;

public class NegativeNumber
{
	public static void Class1()
	{
		Console.WriteLine($"Enter The Size of Array : ");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] nums = new int[n];
		for(int i =  0; i < n; i++)
		{
			nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
			if (nums[i] < 0)
			{
                Console.WriteLine($" First Negative Number is : {nums[i]} ");
				break;
            }
        }


    }
}
