using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class RomanToIntegerService : ServiceBase<string, int>
    {
        /*
         * INPUT:        => OUTPUT:
         * I             => 1 
         * III           => 3
         * LVIII         => 58
         * CCXLV         => 245
         * CDLIX         => 459
         * CDLXXXIX      => 489
         * DCCCLIV       => 854
         * CMLXVII       => 967
         * MCMXCIV       => 1994
         * MMMIV         => 3004
         * MMMCMXCIX     => 3999
         * */


        protected override int DoRun(string s)
        {
            var dict = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000},
                {"IV", 4},
                {"IX", 9},
                {"XL", 40},
                {"XC", 90},
                {"CD", 400},
                {"CM", 900},
            };

            var sum = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var key = i <= s.Length - 2 ? new string(new[] {s[i], s[i + 1]}) : s[i].ToString();

                if (!dict.ContainsKey(key))
                    key = s[i].ToString();
                else
                    i++;

                sum += dict[key];
            }

            return sum;
        }

        public override void RunTest()
        {
            var r0010 = Run("IX", out var t0010); // 9

            var r0020 = Run("III", out var t0020); // 3

            var r0023 = Run("LVIII", out var t0023); // 58

            var r0025 = Run("CCXLV", out var t0025); // 245

            var r0030 = Run("CDLIX", out var t0030); // 459

            var r0040 = Run("CDLXXXIX", out var t0040); // 489

            // min input
            var r0050 = Run("I", out var t0050); // 1

            // max input
            var r0060 = Run("MMMCMXCIX", out var t0060); // 3999

            // another edge case
            var r0070 = Run("MMMIV", out var t0070); // 3004

            // another edge case
            var r0080 = Run("MCMXCIV", out var t0080); // 1994
        }
    }
}
