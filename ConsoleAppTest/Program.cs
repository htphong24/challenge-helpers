using System;
using HelperLibrary;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = (new FindSmallestMissingIntegerService()).Run(new int[] { int.MinValue, int.MaxValue }, out double time);
            Console.WriteLine(result);
        }
    }
}
