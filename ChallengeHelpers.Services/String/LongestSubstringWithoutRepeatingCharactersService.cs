using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class LongestSubstringWithoutRepeatingCharactersService : ServiceBase<string, int>
    {
        /*
         * INPUT:             => OUTPUT:
         * s="abcabcbb"       => 3
         * s="bbbbbbb"        => 1
         * s="pwwkew"         => 3
         * s="abcabcbbbdef"   => 4
         * s="a"              => 1
         * s=""               => 0
         * s="dvdf"           => 3
         * */

        protected override int DoRun(string s)
        {
            // for testing
            //s = "pwwkew";
            //s = "abcabcbb";
            //s = "abcabcbbbd";
            //s = "abcabcbbbdef";
            //s = "a";

            if (s.Length == 0 || s.Length == 1)
                return s.Length;

            // now s.Length >= 2
            var maxLength = 0;
            var window = new HashSet<char>();
            var windowLeftPointer = 0;
            var windowRightPointer = 0;

            while (windowRightPointer < s.Length)
            {
                // Check if window already contains the character (at windowRightPointer)
                if (!window.Contains(s[windowRightPointer]))
                {
                    // Add the character (at windowRightPointer) to the window
                    window.Add(s[windowRightPointer]);
                    // Move windowRightPointer forward
                    windowRightPointer++;
                }
                else // yes, the character (at windowRightPointer) already exists
                {
                    // Remove the character (at windowLeftPointer) from the window
                    window.Remove(s[windowLeftPointer]);
                    // Move windowLeftPointer forward
                    windowLeftPointer++;
                }

                // Re-calculate maxLength
                maxLength = Math.Max(maxLength, window.Count);
            }

            return maxLength;
        }

    }
}
