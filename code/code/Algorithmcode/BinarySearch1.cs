using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class BinarySearch1
    {
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearch(int[] nums, int left, int right, int target)
        {
            //int mid = (left + right) / 2;
            if (left > right) return -1;
            else
            {
                int mid = (left + right) / 2;
                if (target < nums[mid])
                    return BinarySearch(nums, left, mid - 1, target);
                else if (target > nums[mid])
                    return BinarySearch(nums, mid + 1, right, target);
                else
                    return mid;
            }
        }

        #region 二分查找   循环迭代 或 递归
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
        private int Searchdigui(int[] nums, int start, int end, int target)
        {
            int mid = (start + end) / 2;
            if (start <= end)
            {
                if (target < nums[mid])
                {
                    return Searchdigui(nums, start, mid - 1, target);
                }
                else if (target > nums[mid])
                {
                    return Searchdigui(nums, mid + 1, end, target);
                }
                else
                {
                    return mid;
                }
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
