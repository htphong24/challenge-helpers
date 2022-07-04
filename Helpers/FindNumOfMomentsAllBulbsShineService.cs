using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
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
            var result = 0;

            var N = A.Length;

            for (var i = 1; i <= N; i++)
            {
                var l = A.Take(i);
                var l2 = Enumerable.Range(1, i);
                l2 = l2.Except(l);
                if (!l2.Any()) // all bulbs turned on
                    result++;
            }

            return result;
        }

    }
}
