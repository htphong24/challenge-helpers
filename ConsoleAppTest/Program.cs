using System;
using System.Linq;
using HelperLibrary;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new FindSmallestMissingIntService().Run(new[] { int.MinValue, int.MaxValue }, out var time);
            new FindSmallestIntSameNumOfDigitsService().RunTest();
            new FindMinNumOfStrokesService().RunTest();
            new FindLongestBinaryGapService().RunTest();
            new RomanToIntegerService().RunTest();
            new CheckPalindromeLinkedListService().RunTest();
            new RansomNoteService().RunTest();
            new ReverseLinkedListService().RunTest();
            new MiddleOfTheLinkedListService().RunTest();
            new Remove1ElementToMakeTheArrayStrictlyIncreasingService().RunTest();
            new BuddyStringsService().RunTest();
            new CheckIfAStringContainsAllBinaryCodesService().RunTest();
            new IntegerReplacementService().RunTest();
        }
    }
}
