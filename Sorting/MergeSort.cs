/*Merge Sort - Sort an Array of Book Prices
Problem Statement:
A bookstore maintains a list of book prices in an array. Implement Merge Sort in C# to sort
the prices in ascending order.
Hint:
● Divide the array into two halves recursively.
● Sort both halves individually.
● Merge the sorted halves by comparing elements.*/


using System;

public class MergeSorting
{
	public static void Sort()
	{
        Console.WriteLine("Enter The Number of Books :");
        int n = int.Parse(Console.ReadLine());
        int[] prices = new int[n];
        for (int i = 0; i < n; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(prices, 0, n - 1);
        Console.WriteLine(" Merge Sort : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + prices[i]);
        }
    }

    public static void MergeSort(int[] arr, int l , int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;

            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }
    }

    public static void Merge(int[] arr,int l, int m , int r)
    {
        int s1 = m - l + 1;
        int s2 = r - m;

        int[] arr1 = new int[s1];
        int[] arr2 = new int[s2];

        for(int index = 0; index < s1; index++)
        {
            arr1[index] = arr[l+ index];
        }
        for (int index = 0; index < s2; index++)
        {
            arr2[index] = arr[m +1+ index];
        }

        int i = 0;
        int j = 0;
        int k = l;
        while( i < s1 && j < s2)
        {
            if (arr1[i] > arr2[j])
            {
                arr[k] = arr2[j];
                j++;
            }
            else
            {
                arr[k] = arr1[i];
                i++;
            }
            k++;
        }

        while (i < s1)
        {
            arr[k] = arr1[i];
            i++;
            k++;
        }
        while (j < s2)
        {
            arr[k] = arr2[j];
            j++;
            k++;
        }
    }
}
