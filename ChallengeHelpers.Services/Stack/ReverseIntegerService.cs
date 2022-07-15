using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class ReverseIntegerService : ServiceBase<int, int>
    {
        /*
         * INPUT:                    => OUTPUT:
         *           123             =>  321
         *          -123             => -321
         * 2,147,483,647             =>    0
         *-2,147,483,648             =>    0
         *             0             =>    0
         *           120             =>   21
         * */

        protected override int DoRun(int x)
        {
            // test
            //x = 123;
            //x = 2147483647;
            //x = -123;
            //x = -2147483648;

            return Approach2(x);
        }

        private int Approach2(int x)
        {
            int result = 0;

            while (x != 0)
            {
                // Get the right most digit
                var pop = x % 10;
                // Remove the right most digit
                x /= 10;

                // Check if calculating the reversed integer will cause overflow
                if (result > int.MaxValue / 10 ||
                    // Compare with 2,147,483,647
                    result == int.MaxValue / 10 && pop > 7)
                    return 0;

                if (result < int.MinValue / 10 ||
                    // Compare with -2,147,483,648
                    result == int.MinValue / 10 && pop < -8)
                    return 0;

                // Calculate the reversed integer
                result = result * 10 + pop;
            }

            return result;
        }

        private int Approach1(int x)
        {
            if (x == int.MinValue)
                return 0;

            var isNegative = x < 0;

            var stack = ConvertNumberToStack(Math.Abs(x));
            var reversedInt = ConvertStackToNumber(stack);

            return isNegative ? reversedInt * -1 : reversedInt;
        }

        private Stack<int> ConvertNumberToStack(int x)
        {
            var stack = new Stack<int>();

            while (x > 0)
            {
                var remainder = x % 10;
                stack.Push(remainder);
                x /= 10;
            }

            return stack;
        }

        private int ConvertStackToNumber(Stack<int> stack)
        {
            var i = 0;
            double sum = 0;
            while (stack.Count != 0)
            {
                var n = stack.Pop();
                sum += n * Math.Pow(10, i);
                i++;
            }
            return sum > int.MaxValue || sum < int.MinValue ? 0 : (int)sum;
        }
    }
}
