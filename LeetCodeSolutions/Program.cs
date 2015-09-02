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
