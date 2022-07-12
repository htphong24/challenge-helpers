using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class TwoSumService : ServiceBase<TwoSumRequest, int[]>
    {
        /*
         * INPUT:                                    => OUTPUT:
         * nums = [2,7,11,15] & target = 9           => [0,1]
         * nums = [3,2,4]     & target = 6           => [1,2]
         * nums = [3,3]       & target = 6           => [0,1]
         * 
         * */


        protected override int[] DoRun(TwoSumRequest rq)
        {
            var traversed = new Dictionary<int, int>();

            for (int i = 0; i < rq.Nums.Length; i++)
            {
                // a + b = target
                var a = rq.Nums[i];
                var b = rq.Target - a;

                if (traversed.ContainsKey(b))
                    return new[] { traversed[b], i };
                else if (!traversed.ContainsKey(a))
                    traversed.Add(a, i);
            }

            return null;
        }
    }

    public class TwoSumRequest
    {
        public TwoSumRequest(int[] nums, int target)
        {
            Nums = nums;
            Target = target;
        }

        public int[] Nums { get; }

        public int Target { get; }
    }

}
