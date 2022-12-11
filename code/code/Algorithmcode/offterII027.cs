using code.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class offterII027
    {
        //思路：栈

        /// <summary>
        /// 剑指 Offer II 027. 回文链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            int count = 0;
            ListNode temp = head;
            while (temp != null)
            {
                count += 1;
                temp = temp.next;
            }
            ListNode temp1 = head;
            for (int i = 0; i < count / 2; i++)
            {
                stack.Push(temp1.val);
                temp1 = temp1.next;
            }
            if (count % 2 == 0)
            {
                for (int i = count / 2; i < count; i++)
                {
                    if (temp1.val != stack.Pop())
                        return false;
                    else
                        temp1 = temp1.next;
                }
                return true;
            }
            else
            {
                temp1 = temp1.next;
                for (int i = count / 2 + 1; i < count; i++)
                {
                    if (temp1.val != stack.Pop())
                        return false;
                    else
                        temp1 = temp1.next;

                }
                return true;
            }


        }
    }
}
