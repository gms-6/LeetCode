using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class mianshi0104
    {
        /// <summary>
        /// leet 01.04. 回文排列
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CanPermutePalindrome(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                bool b = false;
                foreach (var item in dic)
                {
                    if (item.Key == s[i])
                    {
                        dic[item.Key] += 1;
                        b = true;
                    }
                }
                if (!b)
                {
                    dic.Add(s[i], 1);
                }
            }
            int count = 0;
            foreach (var item in dic)
            {
                if (item.Value % 2 != 0)
                {
                    count += 1;
                }
            }
            if (count > 1)
                return false;
            else
                return true;
        }
    }
}
