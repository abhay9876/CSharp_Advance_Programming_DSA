/*Binary Search Problem 4: Find the First and Last Occurrence of an Element in a Sorted
Array
Problem: Given a sorted array and a target element, write a program that uses Binary Search
to find the first and last occurrence of the target element in the array.*/

using System;

public class Occurence
{
	public static void Class1()
	{
        Console.WriteLine($"Enter a size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter a sorted  array : ");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Enter the target : ");
        int target = Convert.ToInt32(Console.ReadLine());

        int left = 0;
        int right = n - 1;
        int result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;       
                left = mid + 1;     
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        Console.WriteLine($"The last occurence  is : {result}");

         left = 0;
         right = n - 1;
         result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;      
                right = mid - 1;  
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        Console.WriteLine($"The first occurence  is : {result}");




    }
}
