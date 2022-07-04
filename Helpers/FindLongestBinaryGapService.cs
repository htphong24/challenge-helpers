using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class FindLongestBinaryGapService : ServiceBase<int, int>
    {
        /*
         * 9    = 1001         => return 2
         * 15   = 1111         => return 0
         * 20   = 10100        => return 1
         * 32   = 100000       => return 0
         * 529  = 1000010001   => return 4
         * 1041 = 10000010001  => return 5
         * 
         * */


        /// <summary>
        /// 
        /// </summary>
        /// <param name="N">1 &lt; N &lt; 2,147,483,647</param>
        /// <returns>Returns 0 if number has no binary gap</returns>
        protected override int DoRun(int N)
        {
            // convert to binary
            var binary = Convert.ToString(N, 2);
            var lastIndexOf1 = binary.LastIndexOf('1');
            var subBinary = binary.Substring(0, lastIndexOf1 + 1);
            var binaries = subBinary.Split('1');
            var lengths = binaries.Select(b => b.Length).ToList();
            return lengths.Max();
        }

        public override void RunTest()
        {
            var r0010 = Run(9, out var t0010); // 2

            // 
            var r0020 = Run(15, out var t0020); // 0

            // 
            var r0023 = Run(20, out var t0023); // 1

            // 
            var r0025 = Run(32, out var t0025); // 0

            // 
            var r0030 = Run(529, out var t0030); // 4

            // 
            var r0040 = Run(1041, out var t0040); // 5

            // min input
            var r0050 = Run(1, out var t0050); // 0

            // max input
            var r0060 = Run(int.MaxValue, out var t0060); // = 2^31 -1 => all 1s => no binary gap => 0

            // another extreme input
            var r0070 = Run(Convert.ToInt32(Math.Pow(2,30)), out var t0070); // = 1000...000 => 0

            // another extreme input
            var r0080 = Run(Convert.ToInt32(Math.Pow(2, 30)) + 1, out var t0080); // = 1000...001 => 30 - 1 = 29

            // another extreme input
            var r0090 = Run(Convert.ToInt32(Math.Pow(2, 30) + Math.Pow(2, 27) + Math.Pow(2, 5) + Math.Pow(2, 11)) +  1, out var t0090); // = 27 - 11 - 1 = 15
        }
    }
}
