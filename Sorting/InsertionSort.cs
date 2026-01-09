/*Insertion Sort - Sort Employee IDs
Problem Statement:
A company stores employee IDs in an unsorted array. Implement Insertion Sort in C# to sort
the employee IDs in ascending order.
Hint:
● Divide the array into sorted and unsorted parts.
● Pick an element from the unsorted part and insert it into its correct position in the
sorted part.
● Repeat for all elements.*/

using System;

public class Insertion
{
	public static void Sort()
	{
        Console.WriteLine("Enter The Number of Employee :");
        int n = int.Parse(Console.ReadLine());
        int[] emp = new int[n];
        Console.WriteLine("Enter Employee ID's:");
        for (int i = 0; i < n; i++)
        {
            emp[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 1; i< n; i++)
        {
            int key = emp[i];
            int j = i - 1;
            while(j>= 0 && emp[j] > key)
            {
                emp[j + 1] = emp[j];
                j = j - 1;
            }
            emp[j+1] = key;
        }

        Console.WriteLine(" Insertion Sort : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + emp[i]);
        }
    }
}
