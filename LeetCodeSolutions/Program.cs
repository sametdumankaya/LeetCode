using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem268 p = new Problem268();
            int[] array = new int[] {0,1,2,3,5};

            Console.WriteLine(p.MissingNumber(array));

            Console.ReadLine();
        }

        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " - ");
                head = head.next;
            }

            Console.WriteLine();
        }
    }
}
