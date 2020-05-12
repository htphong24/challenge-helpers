using System;

namespace HelperLibrary
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
            int numOfDigits = number.ToString().Length;
            return numOfDigits == 1
                ? 0
                : Math.Pow(10, numOfDigits - 1);
        }

        public override void RunTest()
        {
            double r0010 = Run(1, out double t0010); // 0

            double r0020 = Run(10, out double t0020); // 10

            double r0025 = Run(125, out double t0025); // 100

            // test min value
            double r0030 = Run(0, out double t0030); // 0

            // test max value
            double r0040 = Run(1000 * 1000 * 1000, out double t0040); // 1000 * 1000 * 1000

            // test max value - 1
            double r0050 = Run(999999999, out double t0050); // 100 * 1000 * 1000

            // test random large number
            double r0060 = Run(43545264, out double t0060); // 10 * 1000 * 1000

            double r0070 = Run(000, out double t0070); // 0

        }
    }
}
