using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class IntegerReplacementService : ServiceBase<int, int>
    {
        /*
         * Given a positive integer n, if n is even => n = n/2, if odd => n = n + 1 or n = n - 1
         * Return the minimum number of operations needed for n to become 1.
         * Constraints: 1 <= n <= 231 - 1
         * 
         * INPUT:                    => OUTPUT:
         * n = 8                     => 3 (8 -> 4 -> 2 -> 1)
         * n = 7                     => 4 (7 -> 8 -> 4 -> 2 -> 1 or 7 -> 6 -> 3 -> 2 -> 1)
         *
         * */

        protected override int DoRun(int n)
        {
            return Dfs(n);

            //var memo = new Dictionary<int, int>();
            //return DfsWithMemo(n, memo);
        }

        private int Dfs(int n)
        {
            int result;

            // recursion ends here
            if (n == 1)
                result = 0;
            else
            {
                // if n is even
                if (n % 2 == 0)
                {
                    // increase 1 operation
                    result = 1 + Dfs(n / 2); // this is O (n)
                }
                // if n is odd
                else
                {
                    if (n == int.MaxValue)
                        // compute F (n - 1) & F (n / 2) then take the smaller one
                        result = 1 + Math.Min(Dfs(n - 1), Dfs(n / 2)); // this is O (n + n) = O (n)
                    else
                        // compute F (n - 1) & F (n + 1) then take the smaller one
                        result = 1 + Math.Min(Dfs(n - 1), Dfs(n + 1)); // this is O (n + n) = O (n)
                }
            }

            // Complexity is O (n)
            return result;
        }

        private int DfsWithMemo(int n, IDictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            int result;

            // recursion ends here
            if (n == 1)
                result = 0;
            else
            {
                // if n is even
                if (n % 2 == 0)
                {
                    // increase 1 operation
                    result = 1 + DfsWithMemo(n / 2, memo);
                }
                // if n is odd
                else
                {
                    if (n == int.MaxValue)
                        // compute F (n - 1) & F (n / 2) then take the smaller one
                        result = 1 + Math.Min(DfsWithMemo(n - 1, memo), DfsWithMemo(n / 2, memo));
                    else
                        // compute F (n - 1) & F (n + 1) then take the smaller one
                        result = 1 + Math.Min(DfsWithMemo(n - 1, memo), DfsWithMemo(n + 1, memo));
                }
            }

            // memoize the computed operations
            memo.Add(n, result);

            return result;
        }

        public override void RunTest()
        {
            var r0010 = Run(8, out var t0010); // 3

            var r0020 = Run(7, out var t0020); // 4

            var r0030 = Run(1, out var t0030); // 0

            var r0040 = Run(4096, out var t0040); // 12

            var r0050 = Run(67, out var t0050); // 8

            var r0060 = Run(25, out var t0060); // 6

            var r0070 = Run(28, out var t0070); // 6

            var r0080 = Run(29, out var t0080); // 7

            var r0090 = Run(63, out var t0090); // 7

            var r0100 = Run(4097, out var t0100); // 13

            var r0200 = Run(2147483647, out var t0200); // n = 2^31 - 1 = 2,147,483,647 => 32

        }
    }

}
