using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    /// <summary>
    /// LeetCode problem# 31
    /// </summary>
    public class NextPermutationService : ServiceBase<int[], int[]>
    {
        /*
         * INPUT:               => OUTPUT:
         * [1,5,8,4,7,6,5,3,1]  => [1,5,8,5,1,3,4,6,7]
         * [1,2]                => [2,1]
         * [1,2,3]              => [3,1,2]
         * [3,2,1]              => [1,2,3]
         * [1,1,5]              => [1,5,1]
         * */

        /// <summary>
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        protected override int[] DoRun(int[] nums)
        {
            // example: 
            //nums = new[] {1, 5, 8, 4, 7, 6, 5, 3, 1};
            //              0  1  2  3  4  5  6  7  8
            // Time Complexity is O(n) since only 1 loop is performed at a time
            // Space Complexity is O(1) since no extra space is used.

            // Run backward to find index of the element that is right before strictly decreasing sub array
            // e.g. [1,5,8,4,7,6,5,3,1]
            //                      <= starts from here
            // => 4 is right before this strictly decreasing sub array [7,6,5,3,1]
            // => index of 4 is 3
            int i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }

            // if the element in question is found (nums[i]) => i >= 0
            // otherwise                                     => i = -1
            if (i >= 0)
            {
                // find an element (nums[j]) in the strictly decreasing sub array that nums[j] > nums[i] 
                int j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                // Found that element (e.e. 5 at index 6) => swap them (i.e. swap 4 & 5)
                Swap(nums, i, j);
            }

            // Reverse the strictly decreasing sub array (i.e. reverse [7, 6, 4, 3, 1] to be [1, 3, 4, 6, 7])
            ReverseArray(nums, i + 1);
            // Final result: [1, 5, 8, 5, 1, 3, 4, 6, 7]
            return nums;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        /// <summary>
        /// Reverses the specified array from "start" index to the end
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        private static void ReverseArray(int[] arr, int start)
        {
            var end = arr.Length - 1;
            var i = start;
            var j = end;
            while (i < j)
            {
                Swap(arr, i, j);
                i++;
                j--;
            }
        }

    }
}
