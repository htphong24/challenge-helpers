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

        public override void RunTest()
        {
            var r0010 = Run(1, out var t0010); // 0

            var r0020 = Run(10, out var t0020); // 10

            var r0025 = Run(125, out var t0025); // 100

            // test min value
            var r0030 = Run(0, out var t0030); // 0

            // test max value
            var r0040 = Run(1000 * 1000 * 1000, out var t0040); // 1000 * 1000 * 1000

            // test max value - 1
            var r0050 = Run(999999999, out var t0050); // 100 * 1000 * 1000

            // test random large number
            var r0060 = Run(43545264, out var t0060); // 10 * 1000 * 1000

            var r0070 = Run(000, out var t0070); // 0

        }
    }
}
