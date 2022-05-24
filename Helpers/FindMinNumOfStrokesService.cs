using System;

namespace HelperLibrary
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

        public override void RunTest()
        {
            var r0010 = Run(new int[] { 1, 3, 2, 1, 2 }, out var t0010); // 4

            // 
            var r0020 = Run(new int[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 }, out var t0020); // 9

            // 
            var r0023 = Run(new int[] { 3, 3, 8, 2, 5, 7, 4, 1, 1, 2, 2, 6, 7, 9, 9, 8, 4, 1 }, out var t0023); // 21

            // 
            var r0025 = Run(new int[] { 5, 8 }, out var t0025); // 8

            // 
            var r0030 = Run(new int[] { 1, 1, 1, 1 }, out var t0030); // 1

            // 
            var r0040 = Run(new int[] { 1 }, out var t0040); // 1

            // 
            var r0050 = Run(new int[] { 1000 * 1000 * 1000 }, out var t0050); // 1000,000,000

            // 
            var r0060 = Run(new int[] { 1000 * 1000 * 1000, 1000 * 1000 * 1000, 1000 * 1000 * 1000 }, out var t0060); // 1000,000,000

            // 
            var r0070 = Run(new int[] { 1, 1000 * 1000 * 1000, 1, 1000 * 1000 * 1000, 1, 1000 * 1000 * 1000 }, out var t0070); // 2,999,999,998 => -1

            // 
            var randomArray0010 = Helper.GenerateRandomArray(min: 1, max: 1000 * 1000, length: 1000);
            var r0080 = Run(randomArray0010, out var t0080); // (?!)

            // 
            var randomArray0020 = Helper.GenerateRandomArray(min: 1, max: 1000 * 1000 * 1000, length: 100 * 1000);
            var r0090 = Run(randomArray0020, out var t0090); // -1 (?!)

            // 
            var consecutiveArray0010 = Helper.GenerateConsecutiveArray(min: 999999777, max: 1000 * 1000 * 1000);
            var r0100 = Run(consecutiveArray0010, out var t0100); // max

            //
            var consecutiveArray0020 = Helper.GenerateConsecutiveArray(min: 1, max: 100 * 1000);
            var r0110 = Run(consecutiveArray0020, out var t0110); // max

            var consecutiveArray0030 = Helper.GenerateConsecutiveArray(min: 50, max: 99856);
            var r0120 = Run(consecutiveArray0030, out var t0120); // max
        }
    }
}
