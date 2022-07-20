using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    /// <summary>
    /// LeetCode problem# 1046
    /// </summary>
    public class LastStoneWeightService : ServiceBase<int[], int>
    {
        /*
         * INPUT:                      => OUTPUT:
         * [2,7,4,1,8,1]               => [2,4,1,1,1]
         *                             => [2,1,1,1]
         *                             => [1,1,1]
         *                             => [1]
         *                             => 1
         *                             
         * [1]                         => 1
         * 
         * [1000,950,100,10,3,1]       => [50,100,10,3,1]
         *                             => [50,90,3,1]
         *                             => [40,3,1]
         *                             => [37,1]
         *                             => [36]
         *                             => 36
         *                             
         * [6,38,100,9,89]             => [6,38,11,9]
         *                             => [6,27,9]
         *                             => [6,18]
         *                             => [12]
         *                             => 12
         * */


        protected override int DoRun(int[] stones)
        {
            // Example:
            //stones = new[] { 10, 950, 1000, 3, 100, 1 }; // for testing
            // Time Complexity is O(nlogn)
            // Space Complexity is O(n) since the queue has to store <stones.Length> elements

            var queue = new PriorityQueue<int, int>();
            foreach (var stone in stones) // O(n)
            {
                // Multiply -1 to make the priority queue a MAX Heap
                queue.Enqueue(stone, stone * (-1));
            }

            while (queue.Count > 1) // O(n)
            {
                int max = queue.Dequeue(); // O(logn)
                int secondMax = queue.Dequeue(); // O(logn)
                int newWeight = max - secondMax;
                queue.Enqueue(newWeight, newWeight * (-1)); // O(logn)
            }

            // Get the last element
            return Math.Abs(queue.Peek()); // O(1)
        }

    }
}
