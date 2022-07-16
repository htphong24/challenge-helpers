using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    /// <summary>
    /// LeetCode problem 22. Generate Parentheses
    /// </summary>
    public class GenerateParenthesesService : ServiceBase<int, IList<string>>
    {
        /*
         * INPUT:    => OUTPUT:
         * n is number of pairs of parentheses
         * n=1       => ["()"]
         * n=2       => ["(())","()()"]
         * n=3       => ["((()))","(()())","(())()","()(())","()()()"]
         * */

        /// <summary>
        /// Time & Space complexity is O(2^2n) or O(2^n) since there are 2 cases to check every time we are about to add a new parenthesis 
        /// (i.e. will we add "open" or will we add "closed" parenthesis?)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        protected override IList<string> DoRun(int n)
        {
            var result = new List<string>();
            return GenerateParentheses("", result, 0, 0, n);
        }

        private static IList<string> GenerateParentheses(string parentheses, IList<string> list, int openCount, int closedCount, int numberOfPairs)
        {
            if (openCount == numberOfPairs && closedCount == numberOfPairs)
                // stop recursion & add the current string to the list
                list.Add(parentheses);

            // Add open parenthesis
            if (openCount <= numberOfPairs)
                GenerateParentheses(parentheses + "(", list, openCount + 1, closedCount, numberOfPairs);

            // Add closed parenthesis
            if (closedCount < openCount)
                GenerateParentheses(parentheses + ")", list, openCount, closedCount + 1, numberOfPairs);

            return list;
        }
    }
}
