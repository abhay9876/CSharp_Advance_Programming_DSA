/*Selection Sort - Sort Exam Scores
Problem Statement:
A university needs to sort students’ exam scores in ascending order. Implement Selection
Sort in C# to achieve this.
Hint:
● Find the minimum element in the array.
● Swap it with the first unsorted element.
● Repeat the process for the remaining elements.*/

using System;

public class SelectionSorting
{
	public static void  Sort()
	{
        Console.WriteLine("Enter The Number of Students :");
        int n = int.Parse(Console.ReadLine());
        int[] scores = new int[n];
        for (int i = 0; i < n; i++)
        {
            scores[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort(scores);
        Console.WriteLine(" Selection Sort : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + scores[i]);
        }
    }

    public static void SelectionSort(int[] arr)
    {
        for(int i = 0; i<arr.Length -1; i++)
        {
            int min = i;

            for(int j = i+1; j<arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
}
