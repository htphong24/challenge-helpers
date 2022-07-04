using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class MiddleOfTheLinkedListService : ServiceBase<ListNode, ListNode>
    {
        /*
         * INPUT:        => OUTPUT:
         * [1,2,3,4,5]   => [3,4,5]
         * [1,2,3,4,5,6] => [4,5,6]
         * [1]           => [1]
         * [1,2]         => [1,2]
         * */

        protected override ListNode DoRun(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast?.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                // ***** slow = 1, fast = 1 *****
                // slow = 2
                // fast = 3

                // ***** slow = 2, fast = 3 *****
                // slow = 3
                // fast = 5

                // ***** slow = 3, fast = 5 *****
                // slow = 4
                // fast = null
            }

            return slow;
        }

        public override void RunTest()
        {
            // [1,2,3,4,5]
            var node0010A = new ListNode(5); // last node
            var node0010B = new ListNode(4, node0010A);
            var node0010C = new ListNode(3, node0010B);
            var node0010D = new ListNode(2, node0010C);
            var node0010E = new ListNode(1, node0010D);
            var r0010 = Run(node0010E, out var t0010); // [3,4,5]

            // [1,2,3,4,5,6]
            var node0020A = new ListNode(6); // last node
            var node0020B = new ListNode(5, node0020A);
            var node0020C = new ListNode(4, node0020B);
            var node0020D = new ListNode(3, node0020C);
            var node0020E = new ListNode(2, node0020D);
            var node0020F = new ListNode(1, node0020E);
            var r0020 = Run(node0020F, out var t0020); // [4,5,6]

            // [1]
            var node0030A = new ListNode(1);
            var r0030 = Run(node0030A, out var t0030); // [1]

            // [1,2]
            var node0040A = new ListNode(2); // last node
            var node0040B = new ListNode(1, node0040A);
            var r0040 = Run(node0040B, out var t0040); // [2]

        }
    }
}
