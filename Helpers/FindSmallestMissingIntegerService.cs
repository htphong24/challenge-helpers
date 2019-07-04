using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelperLibrary
{
    public class FindSmallestMissingIntegerService : ServiceBase<int[], int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">List of numbers to find</param>
        /// <returns>Result should be positive (greater than zero)</returns>
        protected override int DoRun(int[] array)
        {
            int result = 1;
            // remove elements <= 0
            List<int> l = array.Where(a => a > 0).ToList();
            if (l.Count == 0 || l.Min() > 1)
            {
                return result;
            }
            else
            {
                // remove duplicate numbers
                l = l.Distinct().ToList();
                // create list of consecutive integers. note that range count 
                // should be = (the original list count + 1) in case the original 
                // list contains consecutive numbers
                IEnumerable<int> l2 = Enumerable.Range(l.Min(), l.Count + 1);
                // get unmatch numbers
                l2 = l2.Except(l);
                // get min number in the unmatch list
                return l2.FirstOrDefault();
            }
        }

        private void DoRun_Test()
        {
            Helper h = new Helper();

            int r0010 = Run(new int[] { 1, 3, 6, 4, 1, 2 }, out double t0010); // 5

            // positive_only
            int r0020 = Run(new int[] { 1, 4, 10 }, out double t0020); // 2

            // positive_only
            int r0025 = Run(new int[] { 100, 101, 102 }, out double t0025); // 1

            // negative_only
            int r0030 = Run(new int[] { -100, -103 }, out double t0030); // 1

            // negative_and_positive
            int r0040 = Run(new int[] { -1000000, 1, 3, 6, 4, 1, 1000000 }, out double t0040); // 2

            // 
            int r0050 = Run(new int[] { 4, 0, 6, 500, 304, 10, 63, 100, 8, 9999, 2 }, out double t0050); // 1
            
            // extreme_single
            int r0060 = Run(new int[] { int.MaxValue }, out double t0060); // 1 
            
            // extreme_min_max_value
            int r0070 = Run(new int[] { int.MinValue, int.MaxValue }, out double t0070); // 1
            
            // empty
            int r0080 = Run(new int[] { }, out double t0080); // 1

            // large random array
            int[] randomArray = h.GenerateRandomArray(min: -1, max: 3, length: 1000);
            int r0090 = Run(randomArray, out double t0090);

            // large consecutive array
            int[] consecutiveArray = h.GenerateConsecutiveArray(min: 1, max: 100 * 1000);
            int r0100 = Run(consecutiveArray, out double t0100); // max + 1
        }
    }
}
