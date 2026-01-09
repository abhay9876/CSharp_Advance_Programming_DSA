/*Problem 1: Convert Byte Stream to Character Stream Using StreamReader
Problem: Write a program that uses StreamReader to read binary data from a file and print
it as characters.*/


using System;
using System.IO;
using System.Text;

public class ConvertByte
{
	public static void Class1()
	{
        string filePath = @"C:\Users\vikra\OneDrive\Desktop\C#_Training\CSharp_ADV_DSA\FileHandling\Test.txt";
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
        {
            int ch;
            while ((ch = reader.Read()) != -1)
            {
                Console.Write((char)ch);
            }
        }
    }
}
