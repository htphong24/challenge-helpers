using ChallengeHelpers.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
{
    public class AddTwoNumbersService : ServiceBase<AddTwoNumbersRequest, ListNode>
    {
        /*
         * INPUT:                      => OUTPUT:
         * [2,4,3] + [5,6,4]           => 342 + 465      = 807         => [7,0,8]
         * [0] + [0]                   => 0 + 0          = 0           => [0]
         * [2,4,9] + [5,6,4,9]         => 942 + 9465     = 10407       => [7,0,4,0,1]
         * [9,9,9,9,9,9,9] + [9,9,9,9] => 9999999 + 9999 = 10009998    => [8,9,9,9,0,0,0,1]
         * [9] + [1,9,9,9,9,9,9,9,9,9] => 9 + 9999999991  = 10000000000 => [0,0,0,0,0,0,0,0,0,0,1] 
         * */


        protected override ListNode DoRun(AddTwoNumbersRequest rq)
        {
            // Test data
            //rq.L1 = new ListNode().AddNodes(new[] { 2, 4, 3 });
            //rq.L2 = new ListNode().AddNodes(new[] { 5, 6, 4 });

            var l1 = rq.L1;
            var l2 = rq.L2;

            var currentNode = new ListNode(0); // Dummy node 
            var head = currentNode; // store the head node so we can return it as the result
            var carry = 0;

            while (l1 != null || l2 != null)
            {
                var sum = carry;

                if (l1 != null)
                {
                    // Add L1's value to sum
                    sum += l1.val;
                    // L1 moves to next node
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    // Add L2's value to sum
                    sum += l2.val;
                    // L2 moves to next node
                    l2 = l2.next;
                }

                // Determine values of carry & sum
                carry = sum / 10;
                sum %= 10;

                // Create new node & link it to currentNode
                currentNode.next = new ListNode(sum);
                // currentNode moves to next node
                currentNode = currentNode.next;
            }

            // Determine whether we should create last node
            if (carry > 0)
            {
                currentNode.next = new ListNode(carry);
                // No need to move currentNode to next node as it's the last node
            }

            head = head.next; // Remove dummy node (0)

            return head;
        }

    }

    public class AddTwoNumbersRequest
    {
        public AddTwoNumbersRequest(ListNode l1, ListNode l2)
        {
            L1 = l1;
            L2 = l2;
        }

        public ListNode L1 { get; set; }

        public ListNode L2 { get; set; }
    }
}
