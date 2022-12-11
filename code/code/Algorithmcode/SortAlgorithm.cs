using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class SortAlgorithm
    {
        #region 顺序查找
        public  void shunxu()
        {

        }

        #endregion

        #region 冒泡排序
        /// <summary>
        /// 冒泡排序  递增
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public  void maopao(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] >= nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            //return nums;
        }
        #endregion


        #region 选择排序
        /// <summary>
        /// 选择排序
        /// 遍历整个数组，先从第一个开始，找出后面最大的一个数与第一个交换
        /// 再从第二个开始，找出后面的最大的一个数与第二个交换
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public  void xuanze(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int count = i;
                int max = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    if (max <= nums[j])
                    {
                        max = nums[j];
                        count = j;
                    }
                }
                int temp = nums[i];
                nums[i] = nums[count];
                nums[count] = temp;
            }
        }
        #endregion

        #region 插入排序
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="nums"></param>
        public  void charu(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (nums[i + 1] < nums[j])
                    {
                        int temp = nums[i + 1];
                        for (int k = i; k >= j; k--)
                        {
                            nums[k + 1] = nums[k];
                        }
                        nums[j] = temp;
                    }
                }
            }
        }
        #endregion

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

        #region 希尔排序  分组插入排序，直至组间距为1
        public  void xier(int[] nums, int gap)
        {
            for (int i = 0; i < nums.Length; i += gap)
            {
                if (i + gap < nums.Length)
                {
                    for (int j = 0; j < i + gap; j += gap)
                    {
                        if (j < nums.Length)
                        {
                            if (nums[i + gap] < nums[j])
                            {
                                int temp = nums[i + gap];
                                for (int k = i; k >= j; k -= gap)
                                {
                                    if (k >= 0)
                                    {
                                        nums[k + gap] = nums[k];
                                    }
                                }
                                nums[j] = temp;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region 归并排序  递归 分治法
        public  void guibing(int[] nums, int start, int end)
        {
            //int[] a=new int[]
            //if()


        }

        #endregion
    }
}
