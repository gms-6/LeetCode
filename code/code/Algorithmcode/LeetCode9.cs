using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode9
    {
        /// <summary>
        /// leet 9. 回文数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            Stack<int> stack = new Stack<int>();
            char[] temp = x.ToString().ToCharArray();
            if (temp.Length % 2 == 0)
            {
                for (int i = 0; i < temp.Length / 2; i++)
                    stack.Push(temp[i]);
                for (int i = temp.Length / 2; i < temp.Length; i++)
                {
                    if (temp[i] != stack.Pop())
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < temp.Length / 2; i++)
                {
                    stack.Push(temp[i]);
                }
                for (int i = temp.Length / 2 + 1; i < temp.Length; i++)
                {
                    if (temp[i] != stack.Pop())
                        return false;
                }
                return true;
            }

        }
    }
}
