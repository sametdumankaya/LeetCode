namespace LeetCodeSolutions.Solutions
{
    class Problem206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode newHead = null;

            while (head != null)
            {
                ListNode nextNode = head.next;
                head.next = newHead;
                newHead = head;
                head = nextNode;
            }
            return newHead;
        }
    }
}
