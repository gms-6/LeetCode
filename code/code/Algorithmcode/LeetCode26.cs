using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode26
    {
        /// <summary>
        /// leet 26.删除有序数组中的重复项
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int i = 0;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
