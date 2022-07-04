using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class LastStoneWeightService : ServiceBase<int[], int>
    {
        /*
         * INPUT:                      => OUTPUT:
         * [2,7,4,1,8,1]               => [2,4,1,1,1]
         *                             => [2,1,1,1]
         *                             => [1,1,1]
         *                             => [1]
         *                             => 1
         *                             
         * [1]                         => 1
         * 
         * [1000,950,100,10,3,1]       => [50,100,10,3,1]
         *                             => [50,90,3,1]
         *                             => [40,3,1]
         *                             => [37,1]
         *                             => [36]
         *                             => 36
         *                             
         * [6,38,100,9,89]             => [6,38,11,9]
         *                             => [6,27,9]
         *                             => [6,18]
         *                             => [12]
         *                             => 12
         * */


        protected override int DoRun(int[] stones)
        {
            //stones = new[] { 10, 950, 1000, 3, 100, 1 }; for testing

            // init (sorted) list
            var list = stones.ToList();

            while (list.Count > 1)
            {
                list = list.OrderBy(e => e).ToList();

                // smash largest stones
                var max = list.ElementAt(list.Count - 1);
                var secondMax = list.ElementAt(list.Count - 2);
                var combo = max - secondMax;
                list.RemoveAt(list.Count - 1);
                list.RemoveAt(list.Count - 1);
                list.Add(combo);
            }

            return list.ElementAt(0);
        }

    }
}
