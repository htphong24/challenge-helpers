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
