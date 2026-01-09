/*Counting Sort - Sort Student Ages
Problem Statement:
A school collects students’ ages (ranging from 10 to 18) and wants them sorted. Implement
Counting Sort in C# for this task.
Hint:
● Create a count array to store the frequency of each age.
● Compute cumulative frequencies to determine positions.
● Place elements in their correct positions in the output array.*/


using System;

public class CountingSort
{
	public static void Sort()
	{
        Console.WriteLine("Enter The Number of Students :");
        int n = int.Parse(Console.ReadLine());
        int[] ages = new int[n];
        for (int i = 0; i < n; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
        }

        int[] res = SelectionSort(ages);
        
        Console.WriteLine(" Counting Sort : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + res[i]);
        }
    }

    public static int[] SelectionSort(int[] arr)
    {
        int max = -1;
        for(int i = 0; i< arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }


        // Count the frequency
        int[] ans = new int[max + 1];
        for (int i = 0; i <= max; i++)
        {
            ans[i] = 0;
        }
        for (int i = 0; i< arr.Length; i++)
        {
            ans[arr[i]]++;
        }


        // Prefix
        for (int i = 1; i < max+1; i++)
        {
            ans[i] += ans[i - 1];
        }

        int[] res = new int[arr.Length];

        for (int i = arr.Length -1; i >= 0; i--)
        {
            int v = arr[i];
            res[ans[v] - 1] = v;
            ans[v]--;
        }
        return res;
    }
}
