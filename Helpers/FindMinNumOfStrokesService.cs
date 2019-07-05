using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelperLibrary
{
    public class FindMinNumOfStrokesService : ServiceBase<int[], int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">Array of heights of N consecutive buildings, 
        /// 1 &lt; N &lt; 100,000 and 1 &lt; array[i] &lt; 1,000,000,000 </param>
        /// <returns>Returns -1 if number of strokes exceeds 1,000,000,000</returns>
        protected override int DoRun(int[] array)
        {
            /*
             * If array = [1, 3, 2, 1, 2]
             * The shape of consecutive buildings will look like this
             *   __
             *   | |_  __
             * __|   |_| |
             * |_________|
             * 
             * */

            // TODO

            Int64 result = 0;

            return result > 1000000000 
                ? -1 
                : Convert.ToInt32(result);

        }

        public override void RunTest()
        {
            int r0010 = Run(new int[] { 1, 3, 2, 1, 2 }, out double t0010); // 4

            // 
            int r0020 = Run(new int[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 }, out double t0020); // 9

            // 
            int r0025 = Run(new int[] { 5, 8 }, out double t0025); // 8

            // 
            int r0030 = Run(new int[] { 1, 1, 1, 1 }, out double t0030); // 1

            // 
            int r0040 = Run(new int[] { 1 }, out double t0040); // 1

            // 
            int r0050 = Run(new int[] { 1000 * 1000 * 1000 }, out double t0050); // 1000,000,000

            // 
            int r0060 = Run(new int[] { 1000 * 1000 * 1000, 1000 * 1000 * 1000, 1000 * 1000 * 1000 }, out double t0060); // 1000,000,000
            
            // 
            int r0070 = Run(new int[] { 1, 1000 * 1000 * 1000, 1, 1000 * 1000 * 1000, 1, 1000 * 1000 * 1000 }, out double t0070); // 2,999,999,998 => -1

            // 
            int[] randomArray0010 = Helper.GenerateRandomArray(min: 1, max: 1000 * 1000 , length: 1000);
            int r0080 = Run(randomArray0010, out double t0080); // (?!)

            // 
            int[] randomArray0020 = Helper.GenerateRandomArray(min: 1, max: 1000 * 1000 * 1000, length: 100 * 1000);
            int r0090 = Run(randomArray0020, out double t0090); // -1 (?!)

            // 
            int[] consecutiveArray0010 = Helper.GenerateConsecutiveArray(min: 999999777, max: 1000 * 1000 * 1000);
            int r0100 = Run(consecutiveArray0010, out double t0100); // max

            //
            int[] consecutiveArray0020 = Helper.GenerateConsecutiveArray(min: 1, max: 100 * 1000);
            int r0110 = Run(consecutiveArray0020, out double t0110); // max

            int[] consecutiveArray0030 = Helper.GenerateConsecutiveArray(min: 50, max: 99856);
            int r0120 = Run(consecutiveArray0030, out double t0120); // max
        }
    }
}
