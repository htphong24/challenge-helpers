using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class CheckIfAStringContainsAllBinaryCodesService : ServiceBase<CheckIfAStringContainsAllBinaryCodesRequest, bool>
    {
        /*
         * INPUT:                    => OUTPUT:
         * s="00110110",k=2          => true (The binary codes of length 2 are "00", "01", "10" and "11". They can be all found as substrings at indices 0, 1, 3 and 2 respectively)
         * s="0110",    k=1          => true (The binary codes of length 1 are "0" and "1", it is clear that both exist as a substring)
         * s="0110",    k=2          => true (The binary code "00" is of length 2 and does not exist in the array)
         *
         * */

        protected override bool DoRun(CheckIfAStringContainsAllBinaryCodesRequest request)
        {
            var s = request.S;
            var k = request.K;

            var subStrings = GetSubString(s, k); // O(n)

            return subStrings.Count == (int) Math.Pow(2, k); // O(1)
        }

        private static HashSet<string> GetSubString(string s, int k)
        {
            var subStrings = new HashSet<string>();

            for (var i = 0; i <= s.Length - k; i++)
                subStrings.Add(s.Substring(i, k));

            return subStrings;
        }

    }

    public class CheckIfAStringContainsAllBinaryCodesRequest
    {
        public string S { get; }

        public int K { get; }

        public CheckIfAStringContainsAllBinaryCodesRequest(string s, int k)
        {
            S = s;
            K = k;
        }
    }
}
