using System;

namespace ChallengeHelpers.Services
{
    public class FindSmallestIntSameNumOfDigitsService : ServiceBase<int, double>
    {
        /// <summary>
        /// Returns the smallest number with the same number of digits of the specified number
        /// </summary>
        /// <param name="number">1&lt;n&lt;10^9</param>
        /// <returns></returns>
        protected override double DoRun(int number)
        {
            var numOfDigits = number.ToString().Length;
            return numOfDigits == 1
                ? 0
                : Math.Pow(10, numOfDigits - 1);
        }

    }
}
