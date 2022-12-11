using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode6258
    {
        /// <summary>
        /// leet 6258. 数组中最长的方波
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestSquareStreak(int[] nums)
        {
            kuaisu(nums, 0, nums.Length - 1);
            int maxcount = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int square = nums[i];
                int max = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == square * square)
                    {
                        square *= square;
                        max++;
                    }
                }
                if (maxcount < max && max >= 2)
                    maxcount = max;
            }
            return maxcount;

        }

        #region 快速排序 对冒泡排序改进
        public void kuaisu(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right;
                int start = nums[i];
                while (i < j)
                {
                    while (start <= nums[j] && i < j) j--;
                    nums[i] = nums[j];
                    while (start >= nums[i] && i < j) i++;
                    nums[j] = nums[i];
                }
                nums[i] = start;
                kuaisu(nums, i + 1, right);
                kuaisu(nums, left, i - 1);
            }
        }
        #endregion
    }
}
