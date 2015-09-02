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
            string str = "    benim  adım       samet   dumankaya              ";

            Console.WriteLine(new Problem151().ReverseWords(str));

            

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
