using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    /// <summary>
    /// LeetCode problem# 60
    /// </summary>
    public class PermutationSequenceService : ServiceBase<PermutationSequenceRequest, string>
    {
        /*
         * INPUT:       => OUTPUT:
         * n=4,k=17     => 3412
         * n=4,k=18     => 3421
         * n=4,k=1      => 1234
         * n=4,k=24     => 4321
         * n=1,k=1      => 1
         * */

        /// <summary>
        /// </summary>
        /// <returns></returns>
        protected override string DoRun(PermutationSequenceRequest rq)
        {
            // example: 
            // n = 4, k = 17 => output should be: 3412
            // Time Complexity is O(n) since only 1 loop is performed at a time
            // Space Complexity is O(n) since we have to create a list contains numbers from 1 to n.

            var n = rq.N;
            var k = rq.K;
            var factorials = new[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320 }; // There's no built-in Factorial function
            var list = new List<int>(n);
            var result = "";

            // It's hard to use the original k to get the correct index, decrease it by 1 will make things easier to calculate
            k--;

            // build the original list, e.g. [1,2,3,4]
            for (int i = 1; i <= n; i++)
                list.Add(i);

            // Loop until "list" is empty
            while (n > 0)
            {
                var index = k / factorials[n - 1]; // 16 / 6 = 2
                                                   //  4 / 2 = 2
                                                   //  0 / 1 = 0
                                                   //  0 / 1 = 0

                k = k % factorials[n - 1]!; // 16 % 12 = 4
                                            //  4 %  2 = 0
                                            //  0 %  1 = 0
                                            //  0 %  1 = 0

                result += list[index]; // 3
                                       // 4
                                       // 1
                                       // 2

                list.RemoveAt(index); // [1,2,4]
                                      //   [1,2]
                                      //     [2]
                                      //      []
                n--;
            }

            return result;
        }

    }

    public class PermutationSequenceRequest
    {
        public PermutationSequenceRequest(int n, int k)
        {
            N = n;
            K = k;
        }

        public int N { get; }
        public int K { get; }
    }
}
