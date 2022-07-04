using System;

namespace ChallengeHelpers.Services
{
    public class FindMinNumOfStrokesService : ServiceBase<int[], int>
    {
        /*
         * If array = [1, 3, 2, 1, 2], the shape of consecutive buildings will look like this
         *    _
         *   | |_   _  => 1 stroke
         *  _|   |_| | => 2 strokes
         * |_________| => 1 stroke
         * 
         * The output should be (1 + 2 + 1) = 4 strokes
         * 
         * Array = [1, 3, 2, 5, 4, 1, 3, 1], simplified array = [3, 2, 5, 1, 3]
         *        _                                 _
         *       | |_        => 1 stroke  =>       | |       
         *    _  |   |  _    => 1 stroke  =>    _  | |  _   
         *   | |_|   | | |   => 3 strokes =>   | |_| | | |  
         *  _|       |_| |_  => 2 strokes =>   |     |_| |
         * |_______________| => 1 stroke  =>   |_________|
         * 
         * => (1 + 1 + 3 + 2 + 1) = 8 strokes
         * 
         * Array = [1, 8, 2, 5, 7, 4, 1, 2, 6, 7, 9, 8, 4, 1], simplified array = [8, 2, 7, 1, 9]
         *                      _                                   _
         *    _                | |_      => 1 stroke  =>    _      | |
         *   | |    _         _|   |     => 2 strokes =>   | |  _  | |
         *   | |   | |      _|     |     => 3 strokes =>   | | | | | |
         *   | |  _| |     |       |     => 3 strokes =>   | | | | | |
         *   | | |   |_    |       |_    => 3 strokes =>   | | | | | |
         *   | | |     |   |         |   => 3 strokes =>   | | | | | |
         *   | |_|     |  _|         |   => 3 strokes =>   | |_| | | |
         *  _|         |_|           |_  => 2 strokes =>   |     |_| |
         * |___________________________| => 1 stroke  =>   |_________|
         * 
         * => 1 + 2 + 3 + 3 + 3 + 3 + 3 + 2 + 1 <=> 8 + (7 - 2) + (9 - 1)
         *  = 21 strokes                         =  8 + 5 
         * 
         * */


        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">Array of heights of N consecutive buildings, 
        /// 1 &lt; N &lt; 100,000 and 1 &lt; array[i] &lt; 1,000,000,000 </param>
        /// <returns>Returns -1 if number of strokes exceeds 1,000,000,000</returns>
        protected override int DoRun(int[] array)
        {
            //   [3, 3, 8, 2, 5, 7, 4, 1, 1, 2, 2, 6, 7, 9, 9, 8, 4, 1]
            // Remove total of array[i] - array[i-1] if array[i] <= array[i-1]
            // = 3 + (8-3) + (5-2) + (7-5) + (2-1) + (6-2) + (7-6) + (9-7) 
            // = 3 + 5 + 3 + 2 + 1 + 4 + 1 + 2
            // = 21

            long result = array[0];
            for (var i = 1; i < array.Length; i++)
                if (array[i] > array[i-1])
                    result += array[i] - array[i - 1];

            return result > 1000000000
                ? -1
                : Convert.ToInt32(result);
        }

    }
}
