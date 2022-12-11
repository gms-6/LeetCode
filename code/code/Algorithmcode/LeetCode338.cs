using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode338
    {

        /// <summary>
        /// leet 338.比特位计数
        /// 公式 x&(x-1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                //result[i] = result[i&(i-1)]+1;
                //result[i] = CountBitsdigui(i);
                result[i] = (i & 1) == 1 ? result[i - 1] + 1 : result[i >> 1];
            }
            return result;
        }
        private  int CountBitsdigui(int n)
        {
            if (n == 0)
                return 0;
            int temp = n & (n - 1);
            temp = CountBitsdigui(temp) + 1;
            return temp;
        }
    }
}
