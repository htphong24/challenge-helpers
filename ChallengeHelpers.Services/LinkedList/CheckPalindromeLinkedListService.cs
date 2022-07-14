using ChallengeHelpers.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHelpers.Services
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
            var list = new List<int> { head.val };

            // start from head
            var current = head;
            while (current.next != null)
            {
                // move to next node
                current = current.next;
                list.Add(current.val);
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
    }
}
