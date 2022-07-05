using System;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public static class Helper
    {
        /// <summary>
        /// Generates an array containing random numbers
        /// </summary>
        /// <param name="min">Min value of the elements in the generated array</param>
        /// <param name="max">Min value of the elements in the generated array</param>
        /// <param name="length">Length generated array</param>
        /// <returns></returns>
        public static int[] GenerateRandomArray(int min, int max, int length)
        {
            int[] result = null;
            var randNum = new Random();
            result = Enumerable
                       .Repeat(0, length)
                       .Select(i => randNum.Next(min, max + 1))
                       .ToArray();
            return result;
        }

        /// <summary>
        /// Generates an array containing consecutive numbers, e.g. [5, 6, 7, 8, 9, 10]
        /// </summary>
        /// <param name="min">Min value of the elements in the generated array</param>
        /// <param name="max">Max value of the elements in the generated array</param>
        /// <returns></returns>
        public static int[] GenerateConsecutiveArray(int min, int max)
        {
            int[] result = null;
            result = Enumerable
                       .Range(start: min, count: max - min + 1) // including the max value
                       .ToArray();
            return result;
        }

    }
}
