/*StringBuilder Problem 2: Remove Duplicates from a String Using StringBuilder
Problem: Write a program that uses StringBuilder to remove all duplicate characters from a
given string while maintaining the original order.*/


using System;
using System.Text;

public class RemoveDuplicate
{
	public static void Class1()
	{
        string str = "Hello";
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (!sb.ToString().Contains(ch))
            {
                sb.Append(ch);
            }
            
        }
        Console.WriteLine("text Without Duplicate   : " + sb.ToString());
    }
}
