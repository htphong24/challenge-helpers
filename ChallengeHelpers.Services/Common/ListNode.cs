namespace ChallengeHelpers.Services
{
    /// <summary>
    /// Linked List Node
    /// </summary>
    public class ListNode
    {
        public int val { get; set; }

        public ListNode next { get; set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode AddNodes(int[] array)
        {
            var currentNode = new ListNode(array[0]); // first node
            var head = currentNode;

            for (int i = 1; i < array.Length; i++)
            {
                currentNode.next = new ListNode(array[i]);
                currentNode = currentNode.next;
            }

            return head;
        }
    }
}
