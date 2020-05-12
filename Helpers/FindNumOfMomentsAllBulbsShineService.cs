using System.Collections.Generic;
using System.Linq;

namespace HelperLibrary
{
    public class FindNumOfMomentsAllBulbsShineService : ServiceBase<int[], int>
    {
        /*
         * A = [2, 1, 3, 5, 4] 
         * => moment A[0] : 2nd bulb on but 1st bulb not
         * => moment A[1] : all bulbs on => result++
         * => moment A[2] : all bulbs on => result++
         * => moment A[3] : 5th bulb on but 4th bulb not
         * => moment A[4] : all bulbs on => result++
         * => result is 3
         * */


        /// <summary>
        /// Finds the number of moments for which every turned on bulb shines
        /// </summary>
        /// <param name="A">Which bulbs are turned on, respectively. 1 &lt; A.Length &lt; 100, 1 &lt; A[i] &lt; 100</param>
        /// <returns></returns>
        protected override int DoRun(int[] A)
        {
            int result = 0;

            int N = A.Length;

            for (int i = 1; i <= N; i++)
            {
                var l = A.Take(i);
                IEnumerable<int> l2 = Enumerable.Range(1, i);
                l2 = l2.Except(l);
                if (!l2.Any()) // all bulbs turned on
                    result++;
            }

            return result;
        }

        public override void RunTest()
        {
            var r0010 = Run(new int[] { 2, 1, 3, 5, 4 }, out double t0010); // 3
            var r0020 = Run(new int[] { 2, 3, 4, 1, 5 }, out double t0020); // 2
            var r0030 = Run(new int[] { 1, 3, 4, 2, 5 }, out double t0030); // 3
            var r0040 = Run(new int[] { 1 }, out double t0040); // 1
            var r0050 = Run(new int[] { 100 }, out double t0050); // 0
            var r0060 = Run(new int[] { 55 }, out double t0060); // 0
            var r0070 = Run(new int[] { 2, 10, 4, 100 }, out double t0070); // 0
            var r0080 = Run(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, out double t0080); // 9
            var r0090 = Run(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 }, out double t0090); // 8
            var r0100 = Run(new int[] { 100, 99, 98, 97, 96, 95, 94, 93, 92 }, out double t0100); // 100
        }
    }
}
