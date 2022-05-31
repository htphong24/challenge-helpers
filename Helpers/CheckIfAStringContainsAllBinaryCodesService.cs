using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelperLibrary
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

        public override void RunTest()
        {
            var r0010 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("00110110", 2), out var t0010); // true

            var r0020 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("0110", 1), out var t0020); // true

            var r0030 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("0110", 2), out var t0030); // false

            var r0040 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("0", 1), out var t0040); // false

            var r0050 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("1", 1), out var t0050); // false

            var r0060 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("0", 2), out var t0060); // false

            var r0070 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("1", 2), out var t0070); // false

            var r0080 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("00010101100111", 3), out var t0080); // true

            var r0090 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("0001010110011", 3), out var t0090); // false

            var r0200 = Run(new CheckIfAStringContainsAllBinaryCodesRequest("0001110111010010011010100000111110101111010110101111111101111110000000100010110111111111010011000111111000010011110100010010000001010011111000010001101100110000110011001110111001001011101111001011001010001101010100000001111000011000101101110011000010100010011001001111000100110001100100101011011001000110101110101101010001011001101001010000101000101010111101111101001011101011001111010101010111011000101000100000100111001110110011010001110001000111000101010010101101001110100100010001101001100011001010111101001011111111000110110000011110111100100001110111110010111101101011101000001001010011100101110111001111010010101100000001111100101000001011010001111111100011011100011101000100010100101011011011101001110111101100000000111110101110011011010100", 16), out var t0200); // ???

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
