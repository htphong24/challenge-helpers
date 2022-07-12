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

    }
}
