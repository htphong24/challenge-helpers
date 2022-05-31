using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelperLibrary
{
    public class Remove1ElementToMakeTheArrayStrictlyIncreasingService : ServiceBase<int[], bool>
    {
        /*
         * INPUT:                    => OUTPUT:
         * [1,2,10,5,7]              => true (Remove 10 => [1,2,5,7] => strictly increasing)
         * [2,3,1,2]                 => false (Remove any element does not make any array strictly increasing)
         * [1,1,1]                   => false (Remove any element does not make any array strictly increasing)
         *
         * */

        protected override bool DoRun(int[] nums)
        {
            // Array with 2 elements will always be strictly increasing after removing 1 element
            if (nums.Length == 2)
                return true;

            // Now handle Array with 3 elements
            var elementsToRemoveCount = 0;
            var pointer = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > pointer)
                {
                    // move pointer to next element
                    pointer = nums[i];
                    continue;
                }

                // nums[i] <= pointer
                elementsToRemoveCount++;

                if (i == 1 || nums[i] > nums[i-2])
                    // move pointer to next element only if the current element is greater than the element at position i-2
                    pointer = nums[i];

                if (elementsToRemoveCount > 1)
                    return false;
            }

            return true;
        }

        public override void RunTest()
        {
            var r0010 = Run(new[] {1, 2, 10, 5, 7}, out var t0010); // true

            var r0020 = Run(new[] {2, 3, 1, 2}, out var t0020); // false

            var r0030 = Run(new[] {1, 1, 1}, out var t0030); // false

            var r0040 = Run(new[] {1, 1}, out var t0040); // true

            var r0050 = Run(new [] {3,1}, out var t0050); // true

            var r0060 = Run(new [] {1,3}, out var t0060); // true

            var r0070 = Run(new [] {1,2,10,10,5,7}, out var t0070); // false

            var r0080 = Run(new [] {1,2,10,5,10,7}, out var t0080); // false

            var r0090 = Run(new [] {1,2,10,5,11,7}, out var t0090); // false

            var r0100 = Run(new [] {3,2,1}, out var t0100); // false

            var r0110 = Run(new [] {3,1,1}, out var t0110); // false

            var r0111 = Run(new[] { 1, 3, 1 }, out var t0111); // true

            var r0112 = Run(new[] { 1, 1, 3 }, out var t0112); // true

            var r0113 = Run(new[] { 3, 1, 2 }, out var t0113); // true

            var r0114 = Run(new[] { 1, 2, 3, 4, 5 }, out var t0114); // true
        }
    }
}
