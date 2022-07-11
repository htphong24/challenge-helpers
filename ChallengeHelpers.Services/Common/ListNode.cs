namespace ChallengeHelpers.Services
{
    /// <summary>
    /// Linked List Node
    /// </summary>
    public class ListNode
    {
        public int Val { get; set; }

        public ListNode Next { get; set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }

        public ListNode AddNodes(int[] array)
        {
            ListNode currentNode;
            var nextNode = new ListNode(array[array.Length - 1]); // first node

            for (int i = array.Length - 2; i >= 0; i--)
            {
                currentNode = new ListNode(array[i], nextNode);
                nextNode = currentNode;
            }

            return nextNode;
        }
    }
}
