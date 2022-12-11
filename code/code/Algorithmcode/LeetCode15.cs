using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode15
    {
        /// <summary>
        /// leet 15. 三数之和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public  IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> list = new List<IList<int>>();
            if (nums.Length < 3) return list;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0)
                    break;
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[left] + nums[right] + nums[i];
                    if (sum == 0)
                    {
                        list.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0) left++;
                    else if (sum > 0) right--;

                }
            }
            return list;

        }
    }
}
