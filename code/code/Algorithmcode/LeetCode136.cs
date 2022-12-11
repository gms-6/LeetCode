using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode136
    {

        /// <summary>
        /// leet 136.只出现一次的数字
        /// 异或操作，出现两次的数字被异或为0 A^A=0 A^A^B=B
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }

    }
}
