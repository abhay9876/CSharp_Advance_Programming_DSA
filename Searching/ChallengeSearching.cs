/*Problem:
You are given a list of integers. Write a program that uses Linear Search to find the first
missing positive integer in the list and Binary Search to find the index of a given target
number.
Approach:
1. Linear Search for the first missing positive integer:
o Iterate through the list and mark each number in the list as visited (you can
use negative marking or a separate array).
o Traverse the array again to find the first positive integer that is not marked.
2. Binary Search for the target index:
o After sorting the array, perform binary search to find the index of the given
target number.
o Return the index if found, otherwise return -1.*/



using System;

public class ChallengeSearching
{
	public static void Searching()
	{
		int max = -1;
	    Console.WriteLine("Enter the Size of Array  : ");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] nums = new int[n];
		for(int i = 0; i< n; i++)
		{
			nums[i] = Convert.ToInt32(Console.ReadLine());
			max = Math.Max(nums[i], max);
        }

		int[] newArr = new int[max+1];
        for (int i = 0; i < n; i++)
        {
			newArr[nums[i]] = 1;
        }

        for (int i = 1; i < newArr.Length; i++)
        {
			if (newArr[i] == 0)
			{
				Console.WriteLine(" First Missing Positive Number is :  " + i);
				break;
			}
        }

		Array.Sort(nums);
        Console.WriteLine($"Enter Target value : ");
        int t = Convert.ToInt32(Console.ReadLine());

        int left = 0;
        int right = n - 1;
		while(left < right)
		{
			int mid = left + (right - left) / 2;
			if (nums[mid]> t)
			{
				right = mid;
			}
			else if (nums[mid] < t)
			{
				left = mid + 1;
			}
			else
			{
				right--;
			}
		}
		Console.WriteLine("The index of Target value is : " + right);



    }
}
