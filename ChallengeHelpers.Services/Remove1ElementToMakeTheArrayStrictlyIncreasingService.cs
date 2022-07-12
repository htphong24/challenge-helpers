using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
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
    }
}
