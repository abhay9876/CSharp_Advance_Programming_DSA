using System;
namespace RuntimeAnalysis
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Linear and Binary
            LargeDataset.Data();


            // RunTime Analysis of Concate string and stringbuilder
            Concatenation.Concatenate();


            RunTime Analysis of reading a file using file stream and streamreader
            StreamComparison.Reading();


            //RunTime Analysis with the help of calculating fabonacci
            Fibonacci.Calculate();
        }
    }
}