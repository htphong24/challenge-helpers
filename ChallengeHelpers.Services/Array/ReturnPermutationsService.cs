using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class ReturnPermutationsService : ServiceBase<int[], IList<IList<int>>>
    {
        /*
         * INPUT:               => OUTPUT:
         * [1,2,3]              => [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
         * [1,2]                => [[1,2],[2,1]]
         * [1]                  => [[1]]
         * */

        /// <summary>
        /// Time Complexity is O(n^n!) since there are n! permutations & there are n levels of decision tree.
        /// The same to Space Complexity.
        ///    ____ ____
        ///   /    |    \
        ///   1    2    3       \    
        ///   /\   /\   /\       \
        ///   2 3  1 3  1 2    ---> n levels of decision tree 
        ///   | |  | |  | |      /
        ///   3 2  3 1  2 1     /
        ///   
        ///   \____  _____/
        ///        \/
        ///        n! permutation
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        protected override IList<IList<int>> DoRun(int[] nums)
        {
            // let's test with nums = [1,2,3,4]
            var result = new List<IList<int>>();
            Permute(result, new List<int>(), nums);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result">Final result</param>
        /// <param name="currentList">starts from an empty list then gets increased until it contains all integers in "nums". e.g. [1,2]</param>
        /// <param name="remainingList">starts from a list that contains all integers in "nums" then gets decreased until there's no integers left in the list</param>
        private static void Permute(List<IList<int>> result, IList<int> currentList, IList<int> remainingList)
        {
            // leaf node
            // => remainingList now should be empty
            //  & currentList now shoule be something like [1,2,3,4]
            // => let's add currentList to result list
            if (remainingList.Count == 0)
            {
                result.Add(currentList);
                return;
            }

            // remainingList is not empty
            foreach (var num in remainingList)
            {
                IList<int> newCurrentList = new List<int>(currentList);
                IList<int> newRemainingList = new List<int>(remainingList);
                newCurrentList.Add(num);
                newRemainingList.Remove(num);
                Permute(result, newCurrentList, newRemainingList);
            }
        }
    }
}
