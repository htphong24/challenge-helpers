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

    }
}
