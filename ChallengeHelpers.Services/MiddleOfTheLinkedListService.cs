namespace ChallengeHelpers.Services
{
    public class MiddleOfTheLinkedListService : ServiceBase<ListNode, ListNode>
    {
        /*
         * INPUT:        => OUTPUT:
         * [1,2,3,4,5]   => [3,4,5]
         * [1,2,3,4,5,6] => [4,5,6]
         * [1]           => [1]
         * [1,2]         => [2]
         * */

        protected override ListNode DoRun(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

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
    }
}
