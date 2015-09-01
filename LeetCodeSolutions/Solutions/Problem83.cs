namespace LeetCodeSolutions.Solutions
{
    class Problem83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode temp = head;

            while (temp != null && temp.next != null)
            {
                if (temp.val == temp.next.val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }

            return head;
        }
    }
}
