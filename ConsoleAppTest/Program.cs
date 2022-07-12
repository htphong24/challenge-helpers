using System;
using System.Linq;
using ChallengeHelpers.Services;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new RomanToIntegerService().RunTest();
            new RansomNoteService().RunTest();
            new ReverseLinkedListService().RunTest();
            new Remove1ElementToMakeTheArrayStrictlyIncreasingService().RunTest();
            new IntegerReplacementService().RunTest();
        }
    }
}
