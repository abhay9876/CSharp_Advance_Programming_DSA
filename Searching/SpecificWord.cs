
/*Linear Search Problem 2: Search for a Specific Word in a List of Sentences
Problem: You are given an array of sentences. Write a program that performs Linear Search
to find the first sentence containing a specific word.*/


using System;

public class SpecificWord
{
	public static void Class1()
	{
        Console.WriteLine($"Enter The Size of Array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] nums = new string[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Console.ReadLine();
        }
        Console.WriteLine($"Enter The Word Want to Find : ");
        string  str = Console.ReadLine();
        for (int i = 0; i < n; i++)
        {
            string s = nums[i];
            if (s.Contains(str)){
                Console.WriteLine($"{s}");
                break;
            }
        }


    }
}
