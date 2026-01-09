/*Problem 2: Count the Occurrence of a Word in a File Using StreamReader
Problem: Write a program that reads a file and counts how many times a specific word
appears in the file.*/

using System;
using System.IO;

public class CountOccurence
{
	public static void Class1()
	{
        string path = @"C:\Users\vikra\OneDrive\Desktop\C#_Training\CSharp_ADV_DSA\FileHandling\Test.txt";
        StreamReader sr = new StreamReader(path);
        string line;
        int count = 0;
        while ((line = sr.ReadLine()) != null)
        {
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'a')
                {
                    count++;
                }
            }
            
        }
        Console.WriteLine("The Occurence Of Char 'a' is : " + count);
    }
}
