using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelperLibrary
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

        public override void RunTest()
        {
            var r0010 = Run(new BuddyStringsRequest("ab", "ba"), out var t0010); // true

            var r0020 = Run(new BuddyStringsRequest("ab", "ab"), out var t0020); // false

            var r0030 = Run(new BuddyStringsRequest("aa", "aa"), out var t0030); // true

            var r0040 = Run(new BuddyStringsRequest("a", "x"), out var t0040); // false

            var r0050 = Run(new BuddyStringsRequest("a", "a"), out var t0050); // false

            var r0060 = Run(new BuddyStringsRequest("phongho", "phongho"), out var t0060); // true

            var r0070 = Run(new BuddyStringsRequest("aaaaaa", "aaaaaa"), out var t0070); // true

            var r0080 = Run(new BuddyStringsRequest("ngocmai", "ngocmai"), out var t0080); // false

            var r0090 = Run(new BuddyStringsRequest("ngocmai","ngacmoi"), out var t0090); // true

            var r0100 = Run(new BuddyStringsRequest("abcd", "badc"), out var t0100); // false

            var r0110 = Run(new BuddyStringsRequest("ab", "babbb"), out var t0110); // false

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
