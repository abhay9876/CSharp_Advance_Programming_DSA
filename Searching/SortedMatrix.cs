/*Binary Search Problem 3: Search for a Target Value in a 2D Sorted Matrix
Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a
program that performs Binary Search to find a target value in the matrix.*/

using System;

public class SortedMatrix
{
	public static void Class1()
	{
        Console.WriteLine($"Enter a size of row : ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter a size of Column : ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter a sorted  array : ");
        int[,] nums = new int[r,c];
        for (int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                nums[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            
        }

        Console.WriteLine($"Enter Target value : ");
        int t = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < r; i++)
        {
            
            int left = 0;
            int right = c - 1;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if(nums[i, mid] == t)
                {
                    found = true;
                    break;
                }
                else
                {
                    if (nums[i, mid] < t)
                    {
                        left = mid + 1;
                    }
                    else if (nums[i, mid] > t)
                    {
                        right = mid;
                    }
                }
                
            }

        }
        if (found)
        {
            Console.WriteLine("Target Found");
        }
        else
        {
            Console.WriteLine("Target not Found");
        }

    }
}
