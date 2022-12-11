using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode20
    {

        /// <summary>
        /// leet 20.有效的括号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public  bool IsValid(string s)
        {
            Stack<char> stack1 = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    stack1.Push(s[i]);
                else if (s[i] == ')' && stack1.Count > 0 && stack1.Peek() == '(')
                    stack1.Pop();
                else if (s[i] == ']' && stack1.Count > 0 && stack1.Peek() == '[')
                    stack1.Pop();
                else if (s[i] == '}' && stack1.Count > 0 && stack1.Peek() == '{')
                    stack1.Pop();
                else
                    return false;

            }
            if (stack1.Count == 0)
                return true;
            else
                return false;
        }
    }
}
