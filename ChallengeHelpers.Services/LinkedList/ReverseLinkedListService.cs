using ChallengeHelpers.Common;

namespace ChallengeHelpers.Services
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
                var tempNext = current.next;
                current.next = prev;
                prev = current;
                current = tempNext;

                // ***current = 1***
                // tempNext = 2
                // 1.next = null
                // prev = 1
                // current = 2

                // ***current = 2***
                // tempNext = 3
                // 2.next = 1
                // prev = 2
                // current = 3

                // ***current = 3***
                // tempNext = 4
                // 3.next = 2
                // prev = 3
                // current = 4

                // ***current = 4***
                // tempNext = 5
                // 4.next = 3
                // prev = 4
                // current = 5

                // ***current = 5***
                // tempNext = null
                // 5.next = 4
                // prev = 5
                // current = null

            }

            return prev;
        }
    }
}
