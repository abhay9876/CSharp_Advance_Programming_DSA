/*Problem 1: Read a File Line by Line Using StreamReader
Problem: Write a program that uses StreamReader to read a text file line by line and print
each line to the console.*/

using System;
using System.IO;

public class ReadFile
{
	public static void Class1()
	{
		string path = @"C:\Users\vikra\OneDrive\Desktop\C#_Training\CSharp_ADV_DSA\FileHandling\Test.txt";
		StreamReader sr = new StreamReader(path);
		string line;
		while((line = sr.ReadLine()) != null)
		{
			Console.WriteLine(line);
		}

    }
}
