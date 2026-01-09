/*StringBuilder Problem 1: Reverse a String Using StringBuilder
Problem: Write a program that uses StringBuilder to reverse a given string. For example, if
the input is "hello", the output should be "olleh".*/

using System;
using System.Text;


public class ReverseString
{
	public static void Class1()
	{
		string str = "Hello";
        StringBuilder sb = new StringBuilder();

        for (int i=str.Length-1; i>=0; i--)
		{
			char ch = str[i];
			sb.Append(ch);
		}

		Console.WriteLine("Reverse : " + sb.ToString());
	}
}
