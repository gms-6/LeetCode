using code.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode2
    {

        /// <summary>
        /// leet 2.两数相加
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode target = new ListNode();
            ListNode temp = target;
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    temp.val += l2.val;
                    if (temp.val >= 10)
                    {
                        temp.val -= 10;
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val += 1;
                        if (l2.next == null)
                            break;
                        //else
                        //    l2 = l2.next;
                        //    continue;
                    }
                    else
                    {
                        if (l2.next == null)
                            break;
                        else
                        {
                            //l2 = l2.next;
                            temp.next = new ListNode();
                            temp = temp.next;
                        }
                    }

                }
                else if (l2 == null)
                {
                    temp.val += l1.val;
                    if (temp.val >= 10)
                    {
                        temp.val -= 10;
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val += 1;
                        if (l1.next == null)
                            break;
                        //else
                        //    l1 = l1.next;

                    }
                    else
                    {
                        if (l1.next == null)
                            break;
                        else
                        {
                            //l1 = l1.next;
                            temp.next = new ListNode();
                            temp = temp.next;
                        }
                    }
                }
                else
                {
                    temp.val = temp.val + l1.val + l2.val;
                    if (temp.val >= 10)
                    {
                        temp.val -= 10;
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val += 1;
                    }
                    else
                    {
                        if (l1.next == null && l2.next == null)
                            break;
                        else
                        {
                            temp.next = new ListNode();
                            temp = temp.next;
                        }
                    }

                }
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

            }
            return target;
        }
    }
}
