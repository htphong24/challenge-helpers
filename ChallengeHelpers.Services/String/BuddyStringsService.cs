using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class BuddyStringsService : ServiceBase<BuddyStringsRequest, bool>
    {
        /*
         * INPUT:                    => OUTPUT:
         * s="ab",goal="ba"          => true (swap s[0] & s[1] to get "ba")
         * s="ab",goal="ab"          => false
         * s="aa",goal="aa"          => true (swap s[0] & s[1] to get "aa")
         *
         * */

        protected override bool DoRun(BuddyStringsRequest request)
        {
            var s = request.S;
            var goal = request.Goal;

            if (s.Length == 1 || goal.Length == 1 || s.Length != goal.Length)
                return false;

            var sDiff = new char[2];
            var goalDiff = new char[2];
            var differences = 0;
            var dict = new Dictionary<char, int>();
            var theresACharOccursTwice = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                {
                    dict[s[i]]++;
                    theresACharOccursTwice = true;
                }

                if (s[i] != goal[i])
                {
                    differences++;

                    if (differences > 2)
                        return false;

                    sDiff[differences - 1] = s[i];
                    goalDiff[differences - 1] = goal[i];
                }
            }

            if (differences == 0)
                // s & goal are exactly the same
                return theresACharOccursTwice;

            if (differences == 2)
                return sDiff[0] == goalDiff[1] && sDiff[1] == goalDiff[0];

            return false;
        }

    }

    public class BuddyStringsRequest
    {
        public string S { get; }

        public string Goal { get; }

        public BuddyStringsRequest(string s, string goal)
        {
            S = s;
            Goal = goal;
        }
    }
}
