using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelperLibrary
{
    public class ReverseLinkedListService : ServiceBase<ListNode, ListNode>
    {
        /*
         * INPUT:        => OUTPUT:
         * [1,2,3,4,5]   => [5,4,3,2,1]
         * [1,2]         => [2,1]
         * []            => []
         * */


        protected override ListNode DoRun(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;

            while (current != null)
            {
                var tempNext = current.Next;
                current.Next = prev;
                prev = current;
                current = tempNext;

                // ***current = 1***
                // tempNext = 2
                // 1.Next = null
                // prev = 1
                // current = 2

                // ***current = 2***
                // tempNext = 3
                // 2.Next = 1
                // prev = 2
                // current = 3

                // ***current = 3***
                // tempNext = 4
                // 3.Next = 2
                // prev = 3
                // current = 4

                // ***current = 4***
                // tempNext = 5
                // 4.Next = 3
                // prev = 4
                // current = 5

                // ***current = 5***
                // tempNext = null
                // 5.Next = 4
                // prev = 5
                // current = null

            }

            return prev;
        }

        public override void RunTest()
        {
            // [1,2,3,4,5]
            var node0010A = new ListNode(5); // last node
            var node0010B = new ListNode(4, node0010A);
            var node0010C = new ListNode(3, node0010B);
            var node0010D = new ListNode(2, node0010C);
            var node0010E = new ListNode(1, node0010D);
            var r0010 = Run(node0010E, out var t0010); // [5,4,3,2,1]

            // [1,2]
            var node0020A = new ListNode(2); // last node
            var node0020B = new ListNode(1, node0020A);
            var r0020 = Run(node0020B, out var t0020); // [2,1]

            // []
            var r0030 = Run(null, out var t0030); // []

            // [1,1,1,1,1]
            var node0040A = new ListNode(1); // last node
            var node0040B = new ListNode(1, node0040A);
            var node0040C = new ListNode(1, node0040B);
            var node0040D = new ListNode(1, node0040C);
            var node0040E = new ListNode(1, node0040D);
            var r0040 = Run(node0040E, out var t0040); // [1,1,1,1,1]

            // [1]
            var node0050A = new ListNode(1); // last node
            var r0050 = Run(node0050A, out var t0050); // [1]
        }
    }
}
