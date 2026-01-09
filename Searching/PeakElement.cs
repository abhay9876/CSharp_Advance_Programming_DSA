/*Binary Search Problem 2: Find the Peak Element in an Array
Problem: A peak element is an element that is greater than its neighbors. Write a program
that performs Binary Search to find a peak element in an array.*/


using System;

public class PeakElement
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
        
        int left= 0;
        int right = n - 1;
        while(left < right)
        {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] < nums[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                
                right = mid;
            }
        }
        Console.WriteLine($"The Peak Value is : {nums[left]}");
    }

}
