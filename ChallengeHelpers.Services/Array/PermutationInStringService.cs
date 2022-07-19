using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    /// <summary>
    /// LeetCode problem# 567
    /// </summary>
    public class PermutationInStringService : ServiceBase<PermutationInStringRequest, bool>
    {
        /*
         * INPUT:                       => OUTPUT:
         * s1="ab",s2="eidbaooo"        => true (s2 contains one permutation of s1 ("ba"))
         * s1="ab",s2="eidboaoo"        => false
         * s1="adc",s2="dcda"           => true
         * s1="abbd",s2="xyzbadbijkl"   => true
         * */

        /// <summary>
        /// </summary>
        /// <returns></returns>
        protected override bool DoRun(PermutationInStringRequest rq)
        {
            // example: 
            // s1 = abbd, s2 = xyzbadbijkl => output: true
            // Time Complexity is O(n) since only 1 loop is performed at a time
            // Space Complexity is O(1) since the 2 arrays has a fixed size of 26

            var s1 = rq.S1;
            var s2 = rq.S2;
            var l1 = s1.Length;
            var l2 = s2.Length;

            if (l1 > l2)
                return false;

            var a1 = new int[26];
            var a2 = new int[26];

            // Init the 2 arrays
            for (int i = 0; i < l1; i++)
            {
                a1[s1[i] - 'a']++;
                a2[s2[i] - 'a']++;
            }

            // Slide the window & check matching
            for (int i = 0; i <= l2 - l1; i++)
            {
                // Check matching since the 2 arrays are already initialized
                if (Match(a1, a2))
                    return true;

                // Slide the window
                // Stop if window reaches the last index (l2 - l1)
                if (i == l2 - l1)
                {
                    return false;
                }
                a2[s2[i + l1] - 'a']++;
                a2[s2[i] - 'a']--;
            }
            return false;
        }

        /// <summary>
        /// Time Complexity is O(1) since 26 is constant, Space Complexity is O(1) since no extra space is needed.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        private bool Match(int[] a1, int[] a2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (a1[i] != a2[i])
                    return false;
            }
            return true;
        }
    }

    public class PermutationInStringRequest
    {
        public PermutationInStringRequest(string s1, string s2)
        {
            S1 = s1;
            S2 = s2;
        }

        public string S1 { get; }
        public string S2 { get; }
    }
}
