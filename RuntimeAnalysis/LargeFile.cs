/*Large File Reading Efficiency
Objective
Compare StreamReader and FileStream when reading a large file (500MB).
Approach
● StreamReader: Reads character by character (slower for binary files).
● FileStream: Reads bytes and converts to characters (more efficient).
File Size StreamReader Time FileStream Time
1MB			50ms			30ms
100MB		3s				1.5s
500MB		10s				 5s
Expected Result
FileStream is more efficient for large files. StreamReader is preferable for text-based data.*/


using System;
using System.Diagnostics;
using System.IO;

class StreamComparison
{
    public static void Reading()
    {
        string path = "largefile.txt";
        Stopwatch sw = new Stopwatch();
        sw.Start();
        using (StreamReader reader = new StreamReader(path))
        {
            while (reader.Read() != -1)
            {
            }
        }
        sw.Stop();
        Console.WriteLine($"StreamReader Time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
            }
        }
        sw.Stop();
        Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds} ms");
    }
}

