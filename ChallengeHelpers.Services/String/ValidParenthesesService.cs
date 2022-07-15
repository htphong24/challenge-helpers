using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class ValidParenthesesService : ServiceBase<string, bool>
    {
        /*
         * INPUT:             => OUTPUT:
         * s="()"             => true
         * s="()[]{}"         => true
         * s="(]"             => false
         * s="["              => fase
         * s="[[({[]})]]"     => true
         * s="[[({[]]})]]"    => false
         * s="[[({[})]]"      => false
         * */

        protected override bool DoRun(string s)
        {
            // s.Length is an odd number => invalid
            if (s.Length % 2 > 0)
                return false;

            var stack = new Stack<char>();

            // nothing to pop at the first index => invalid
            if (s[0] == ')' || s[0] == ']' || s[0] == '}')
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                // open parentheses => push
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    stack.Push(s[i]);
                else // closed parentheses => pop
                {
                    // only pop when stack is not empty
                    if (stack.Count == 0)
                        return false;

                    var parenthesis = stack.Pop();

                    // the parenthesis we have just popped has to match the previous parenthesis
                    if (s[i] != ')' && parenthesis == '(')
                        return false;

                    if (s[i] != ']' && parenthesis == '[')
                        return false;

                    if (s[i] != '}' && parenthesis == '{')
                        return false;
                }
            }

            // Stack should be empty after looping through the string
            return stack.Count == 0;
        }

    }
}
