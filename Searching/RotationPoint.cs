/*Binary Search Problem 1: Find the Rotation Point in a Rotated Sorted Array
Problem: You are given a rotated sorted array. Write a program that performs Binary Search
to find the index of the smallest element in the array.*/

using System;

public class RotationPoint
{
    public static void Class1()
    {
        Console.WriteLine($"Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter a sorted rotated array : ");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        int left = 0;
        int right = n - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else if (nums[mid] < nums[right])
            {
                right = mid;
            }
            else
            {
                right--;
            }
        }

        Console.WriteLine($"The Min Value is : {nums[right]}");
    }
}
