/*Problem 2: Read User Input and Write to File Using StreamReader
Problem: Write a program that reads user input from the console and writes it to a file.*/


using System;
using System.IO;

public class ReadAndWrite
{
	public static void Class1()
	{
		string str = Console.ReadLine();

		string path = @"C:\Users\vikra\OneDrive\Desktop\C#_Training\CSharp_ADV_DSA\FileHandling\Test.txt";

		using (StreamWriter sw = new StreamWriter(path,true))
		{
			sw.WriteLine(str);
		}

		using(StreamReader sr = new StreamReader(path))
		{
			Console.WriteLine(sr.ReadToEnd());
		}
    }
}
