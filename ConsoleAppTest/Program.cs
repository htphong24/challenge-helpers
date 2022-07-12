using System;
using System.Linq;
using ChallengeHelpers.Services;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new Remove1ElementToMakeTheArrayStrictlyIncreasingService().RunTest();
        }
    }
}
