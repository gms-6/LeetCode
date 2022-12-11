using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode27
    {
        /// <summary>
        /// leet 27. 移除元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int left = 0, right = 0;

            while (right < nums.Length)
            {


                if (nums[right] != val)
                {
                    nums[left++] = nums[right++];
                }
                else
                {
                    right++;
                }
            }
            return left;

        }
    }
}
