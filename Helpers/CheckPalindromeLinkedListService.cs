using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelperLibrary
{
    public class CheckPalindromeLinkedListService : ServiceBase<ListNode, bool>
    {
        /*
         * INPUT:                    => OUTPUT:
         * [1,7,3,3,6,5,6,3,3,7,1]   => true
         * [1,7,3,3,6,5,5,6,3,3,7,1] => true
         * [1,7,1]                   => true
         * [1,7,8,1]                 => false 
         * [7]                       => true
         * [7,0]                     => false
         * */


        protected override bool DoRun(ListNode head)
        {
            var list = new List<int> { head.Val };

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
                list.Add(current.Val);
            }

            return IsPalindrome(list);
        }

        private bool IsPalindrome(IList<int> list)
        {
            var length = list.Count;
            var limit = length / 2 - 1;
            for (var i = 0; i <= limit; i++)
                if (list[i] != list[length - 1 - i])
                    return false;

            return true;
        }

        public override void RunTest()
        {
            // [1,7,3,3,6,5,6,3,3,7,1]
            var node0010A = new ListNode(1); // last node
            var node0010B = new ListNode(7, node0010A);
            var node0010C = new ListNode(3, node0010B);
            var node0010D = new ListNode(3, node0010C);
            var node0010E = new ListNode(6, node0010D);
            var node0010F = new ListNode(5, node0010E);
            var node0010G = new ListNode(6, node0010F);
            var node0010H = new ListNode(3, node0010G);
            var node0010I = new ListNode(3, node0010H);
            var node0010J = new ListNode(7, node0010I);
            var node0010K = new ListNode(1, node0010J);
            var r0010 = Run(node0010K, out var t0010); // true

            // [1,7,3,3,6,5,5,6,3,3,7,1]
            var node0020A = new ListNode(1); // last node
            var node0020B = new ListNode(7, node0020A);
            var node0020C = new ListNode(3, node0020B);
            var node0020D = new ListNode(3, node0020C);
            var node0020E = new ListNode(6, node0020D);
            var node0020F = new ListNode(5, node0020E);
            var node0020G = new ListNode(5, node0020F);
            var node0020H = new ListNode(6, node0020G);
            var node0020I = new ListNode(3, node0020H);
            var node0020J = new ListNode(3, node0020I);
            var node0020K = new ListNode(7, node0020J);
            var node0020L = new ListNode(1, node0020K);
            var r0020 = Run(node0020L, out var t0020); // true

            // [1,7,1]
            var node0030A = new ListNode(1); // last node
            var node0030B = new ListNode(7, node0030A);
            var node0030C = new ListNode(1, node0030B);
            var r0030 = Run(node0030C, out var t0030); // true

            // [1,7,8,1]
            var node0040A = new ListNode(1); // last node
            var node0040B = new ListNode(8, node0040A);
            var node0040C = new ListNode(7, node0040B);
            var node0040D = new ListNode(1, node0040C);
            var r0040 = Run(node0040D, out var t0040); // false

            // [7]
            var node0050A = new ListNode(7);
            var r0050 = Run(node0050A, out var t0050); // true

            // [7,0]
            var node0060A = new ListNode(7); // last node
            var node0060B = new ListNode(0, node0060A);
            var r0060 = Run(node0060B, out var t0060); // false
        }
    }

    public class ListNode
    {
        public int Val { get; private set; }

        public ListNode Next { get; private set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
}
