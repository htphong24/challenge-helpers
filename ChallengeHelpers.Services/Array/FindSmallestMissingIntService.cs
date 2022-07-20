using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    /// <summary>
    /// LeetCode problem# 
    /// </summary>
    public class FindSmallestMissingIntService : ServiceBase<int[], int>
    {
        /*
         * INPUT:                      => OUTPUT:
         * 
         * */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">List of numbers to find</param>
        /// <returns>Result should be positive (greater than zero)</returns>
        protected override int DoRun(int[] array)
        {
            const int result = 1;
            // remove elements <= 0
            var l = array.Where(a => a > 0).ToList();

            if (l.Count == 0 || l.Min() > 1)
                return result;

            // remove duplicate numbers
            l = l.Distinct().ToList();
            // create list of consecutive integers. note that range count 
            // should be = (the original list count + 1) in case the original 
            // list contains consecutive numbers
            var l2 = Enumerable.Range(l.Min(), l.Count + 1);
            // get unmatched numbers
            l2 = l2.Except(l);

            // get min number in the unmatched list
            return l2.FirstOrDefault();
        }

    }
}
