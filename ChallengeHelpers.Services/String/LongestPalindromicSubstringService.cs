using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class LongestPalindromicSubstringService : ServiceBase<string, string>
    {
        /*
         * INPUT:             => OUTPUT:
         * s="babad"          => "bab" or "aba"
         * s="cbbd"           => "bb"
         * s="a"              => "a"
         * s="bdcddce"        => "cddc"
         * s="bacdce"         => "cdc"
         * s="ecacddcaf"      => "acddca"
         * s="bacdcaf"        => "acdca"
         * s="xabcbamndedy"   => "abcba"
         * s="xabcbabcby"     => "bcbabcb"
         * s="xabcbaabcbyz"   => "bcbaabcb"
         * */

        protected override string DoRun(string s)
        {
            // for testing
            //s = "xabcbabcbyz";
            //s = "xabcbaabcbyz";

            if (s.Length == 1)
                return s;

            // now s.Length is >= 2
            var start = 0;
            //var end = 0; // in C#, string.substring() only requires length & start index
            var maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // get palindrome substring length
                int length1 = GetPalindromeSubstringLengthByExpandingFromMiddle(s, i, i); // for substrings like "racecar"
                int length2 = GetPalindromeSubstringLengthByExpandingFromMiddle(s, i, i + 1); // for substrings like "raceecar"
                var length = Math.Max(length1, length2);

                if (length > maxLength)
                {
                    maxLength = length;

                    // re-calculate start pointer & end pointer
                    start = i - (length - 1) / 2;
                    //end = i + length / 2;
                }
                
            }

            return s.Substring(start, maxLength);
        }

        private int GetPalindromeSubstringLengthByExpandingFromMiddle(string s, int leftPointer, int rightPointer)
        {
            if (s is null || leftPointer > rightPointer)
                return 0;

            while (leftPointer >= 0 && rightPointer <= s.Length - 1 && s[leftPointer] == s[rightPointer])
            {
                // expand leftPointer to the left
                leftPointer--;
                // expand rightPointer to the right
                rightPointer++;
            }

            // return the length of the palindrome
            return rightPointer - leftPointer - 1;
        }

    }
}
