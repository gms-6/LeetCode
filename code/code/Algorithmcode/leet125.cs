using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    /// <summary>
    /// leet 125. 验证回文串
    /// </summary>
    public class leet125
    {
        /// <summary>
        /// leet 125. 验证回文串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            Stack<int> stack = new Stack<int>();
            char[] temp = new char[s.Length];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    temp[count++] = s[i];
                }
                else if (s[i] >= 97 && s[i] <= 122)
                {
                    temp[count++] = s[i];
                }
                else if (s[i] >= 65 && s[i] <= 90)
                {
                    temp[count] = s[i];
                    temp[count++] += (char)32;
                }
            }
            if (count % 2 == 0)
            {
                for (int i = 0; i < count / 2; i++)
                    stack.Push(temp[i]);
                for (int i = count / 2; i < count; i++)
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
                for (int i = 0; i < count / 2; i++)
                {
                    stack.Push(temp[i]);
                }
                for (int i = count / 2 + 1; i < count; i++)
                {
                    if (temp[i] != stack.Pop())
                        return false;
                }
                return true;
            }
        }
    }
}
