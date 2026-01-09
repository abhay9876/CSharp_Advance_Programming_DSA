/*Quick Sort - Sort Product Prices
Problem Statement:
An e-commerce company wants to display product prices in ascending order. Implement
Quick Sort in C# to sort the product prices.
Hint:
● Pick a pivot element (first, last, or random).
● Partition the array such that elements smaller than the pivot are on the left and
larger ones are on the right.
● Recursively apply Quick Sort on left and right partitions.*/


using System;

public class QuickSorting
{
	public static void Sort()
	{
        Console.WriteLine("Enter The Number of Product :");
        int n = int.Parse(Console.ReadLine());
        int[] prices = new int[n];
        for (int i = 0; i < n; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }
        QuickSort(prices, 0, n - 1);
        Console.WriteLine(" Quick Sort : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + prices[i]);
        }
    }

    public static void QuickSort(int[] arr, int l , int r)
    {
        if (l < r)
        {
            int parIndex = Partition(arr, l, r);

            QuickSort(arr, l, parIndex - 1);
            QuickSort(arr, parIndex + 1, r);
        }
    }

    public static int Partition(int[] arr , int low , int high)
    {
        int pivot = arr[high];

        int i = low-1;
        for(int j = low; j< high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                swap(arr, i, j);
            }
        }
        i++;
        swap(arr, i, high);
        return i;
    }

    static void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
