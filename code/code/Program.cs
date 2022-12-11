using code.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] nums = new int[] { 0,0,0 };
            //int[][] grid = new int[][] { new int[]{1,2,4 },new int[]{3,3,1 } };
            string s = "code";
            bool a=CanPermutePalindrome(s);
        }
        #region 待整理代码
        /// <summary>
        /// 剑指 Offer II 027. 回文链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            int count = 0;
            ListNode temp = head;
            while(temp != null)
            {
                count += 1;
                temp=temp.next;
            }
            ListNode temp1 = head;
            for(int i = 0; i < count/2; i++)
            {
                stack.Push(temp1.val);
                temp1=temp1.next;
            }
            if(count%2==0)
            {
                for (int i = count / 2; i < count; i++)
                {
                    if (temp1.val != stack.Pop())
                        return false;
                    else
                        temp1 = temp1.next;
                }
                return true;
            }
            else
            {
                temp1 = temp1.next;
                for (int i = count / 2 + 1; i < count; i++)
                {
                    if (temp1.val != stack.Pop())
                        return false;
                    else
                        temp1 = temp1.next;

                }
                return true;
            }
            
            
        }
        /// <summary>
        /// leet 01.04. 回文排列
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CanPermutePalindrome(string s)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            for(int i=0;i<s.Length;i++)
            {
                bool b = false;
                foreach (var item in dic)
                {
                    if(item.Key == s[i])
                    {
                        dic[item.Key] += 1;
                        b = true;
                    }
                }
                if(!b)
                {
                    dic.Add(s[i],1);
                }
            }
            int count = 0;
            foreach (var item in dic)
            {
                if(item.Value%2!=0)
                {
                    count += 1;
                }
            }
            if (count > 1)
                return false;
            else
                return true;
        }
        /// <summary>
        /// leet 125. 验证回文串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            Stack<int> stack = new Stack<int>();
            char[] temp=new char[s.Length];
            int count = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>=48&&s[i]<=57)
                {
                    temp[count++] =s[i];
                }
                else if(s[i]>=97&&s[i]<=122)
                {
                    temp[count++] = s[i];
                }
                else if(s[i]>=65&&s[i]<=90)
                {
                    temp[count] = s[i];
                    temp[count++] += (char)32;
                }
            }
            if (count % 2 == 0)
            {
                for (int i = 0; i < count / 2; i++)
                    stack.Push(temp[i]);
                for (int i = count / 2; i < count; i++)
                {
                    if (temp[i] != stack.Pop())
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < count / 2; i++)
                {
                    stack.Push(temp[i]);
                }
                for (int i = count / 2 + 1; i < count; i++)
                {
                    if (temp[i] != stack.Pop())
                        return false;
                }
                return true;
            }
        }
        /// <summary>
        /// leet 9. 回文数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if(x<0)
                return false;
            Stack<int> stack = new Stack<int>();
            char[] temp=x.ToString().ToCharArray();
            if(temp.Length%2==0)
            {
                for(int i=0;i<temp.Length/2;i++)
                    stack.Push(temp[i]);
                for(int i=temp.Length/2;i<temp.Length;i++)
                {
                    if(temp[i]!=stack.Pop())
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for(int i=0;i<temp.Length/2;i++)
                {
                    stack.Push(temp[i]);
                }
                for(int i=temp.Length/2+1;i<temp.Length;i++)
                {
                    if (temp[i] != stack.Pop())
                        return false;
                }
                return true;
            }

        }
        /// <summary>
        /// leet 15. 三数之和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> list = new List<IList<int>>();
            if (nums.Length < 3) return list;
            for (int i=0; i < nums.Length-2; i++)
            {
                if (nums[i] > 0)
                    break;
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int left = i+1, right = nums.Length - 1;
                while (left<right)
                {
                    int sum=nums[left]+nums[right]+nums[i];
                    if(sum==0)
                    {
                        list.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; 
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum<0) left++;
                    else if(sum>0) right--;
                    
                }
            }
            return list;

        }
        /// <summary>
        /// leet 6258. 数组中最长的方波
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestSquareStreak(int[] nums)
        {
            kuaisu(nums, 0, nums.Length - 1);
            int maxcount = -1;
            for(int i=0;i<nums.Length;i++)
            {
                int square=nums[i];
                int max = 1;
                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[j] == square * square)
                    {
                        square *= square;
                        max++;
                    }
                }
                if(maxcount < max&&max>=2)
                    maxcount = max;
            }
            return maxcount;

        }
        /// <summary>
        /// leet 6257. 删除每行中的最大值
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int DeleteGreatestValue(int[][] grid)
        {
            int totalmax = 0;
            for (int n = 0; n < grid[0].Length; n++)
            {
                int[] max = new int[grid.Length * grid[0].Length / grid[0].Length];
                for (int i = 0; i< grid.Length * grid[0].Length / grid[0].Length; i++)   //行数
                {
                    int index = 0;
                    for (int j = grid[0].Length - 1 - n; j >= 0; j--)   //列数 从最后一列开始
                    {
                        if (max[i] < grid[i][j])
                        {
                            max[i] = grid[i][j];
                            index = j;
                        }
                    }
                    //if(index!= grid[0].Length - 1-n)
                    //{
                    //    grid[i][index] = grid[i][grid[0].Length - 1 - n];
                    //}
                    grid[i][index] = grid[i][grid[0].Length - 1 - n];
                }
                int max1 = max[0];
                for (int k = 0; k < max.Length; k++)
                {
                    if (max1 < max[k])
                        max1 = max[k];
                }
                totalmax += max1;
            }
            return totalmax;
            



        }

        /// <summary>
        /// leet 35. 搜索插入位置
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public void SearchInsert(int[] nums, int target)
        {

            //int left=0, right=nums.Length-1;
            //int index = -1;
            //int mid = -1;
            //while (left<right)
            //{
            //    mid = (left+right) / 2;
            //    if (nums[mid] < target) right = mid - 1;
            //    else if (nums[mid] > target) left = mid + 1;
            //    else break;
            //}
            //if(left>=right)


        }
        public int BinarySearch(int[] nums,int left,int right,int target)
        {
            //int mid = (left + right) / 2;
            if (left > right) return -1;
            else
            {
                int mid = (left+right)/2;
                if (target < nums[mid])
                    return BinarySearch(nums,left,mid-1,target);
                else if(target>nums[mid])
                    return BinarySearch(nums,mid+1,right,target);
                else
                    return mid;
            }
        }
        /// <summary>
        /// leet 27. 移除元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int left = 0, right = 0;

            while (right<nums.Length)
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
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[j] != nums[i])
                {
                    nums[++i] = nums[j];
                }
            }
            return i+1;
        }

        /// <summary>
        /// leet 2.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode target = new ListNode();
            ListNode temp = target;
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    temp.val += l2.val;
                    if (temp.val >= 10)
                    {
                        temp.val -= 10;
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val += 1;
                        if (l2.next == null)
                            break;
                        //else
                        //    l2 = l2.next;
                        //    continue;
                    }
                    else
                    {
                        if (l2.next == null)
                            break;
                        else
                        {
                            //l2 = l2.next;
                            temp.next = new ListNode();
                            temp = temp.next;
                        }
                    }
                    
                }
                else if(l2 == null)
                {
                    temp.val += l1.val;
                    if (temp.val >= 10)
                    {
                        temp.val -= 10;
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val += 1;
                        if (l1.next == null)
                            break;
                        //else
                        //    l1 = l1.next;

                    }
                    else
                    {
                        if (l1.next == null)
                            break;
                        else
                        {
                            //l1 = l1.next;
                            temp.next = new ListNode();
                            temp = temp.next;
                        }
                    }
                }
                else
                {
                    temp.val=temp.val+l1.val + l2.val;
                    if(temp.val>=10)
                    {
                        temp.val -= 10;
                        temp.next = new ListNode();
                        temp=temp.next;
                        temp.val += 1;
                    }
                    else
                    {
                        if (l1.next == null && l2.next == null)
                            break;
                        else
                        {
                            temp.next = new ListNode();
                            temp = temp.next;
                        }
                    }
                    
                }
                if(l1!=null)
                    l1= l1.next;
                if(l2!=null)
                    l2= l2.next;
                
            }
            return target;
        }
        /// <summary>
        /// leet 415.字符串相加
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string AddStrings(string num1, string num2)
        {
            StringBuilder sb=new StringBuilder();
            int len1 = num1.Length - 1;
            int len2=num2.Length - 1;
            int temp = 0;
            for (int i = 0; i < Math.Max(num1.Length, num2.Length); i++)
            {

                if (len1 < 0)
                {
                    for (int j = len2; j >= 0; j--)
                    {
                        int c = num2[j] - '0' + temp ;
                        if (c >= 10)
                        {
                            c = c - 10;
                            sb.Append(c);
                            temp = 1;
                        }
                        else
                        {
                            sb.Append(c);
                            temp = 0;
                        }
                    }
                    break;
                }
                else if (len2 < 0)
                {
                    for (int j = len1; j >= 0; j--)
                    {
                        int c = num1[j] - '0' + temp;
                        if (c >= 10)
                        {
                            c = c - 10;
                            sb.Append(c);
                            temp = 1;
                        }
                        else
                        {
                            sb.Append(c);
                            temp = 0;
                        }
                    }
                    break;
                }
                else if (len1<0&&len2<0)
                    break;
                int x = num1[len1] - '0';
                int y = num2[len2] - '0';
                if (x + y+temp >= 10)
                {
                    int c = x + y - 10+temp;
                    sb.Append(c);
                    temp = 1;
                    len1--;
                    len2--;
                }
                else
                {
                    int c = x + y +temp;
                    sb.Append(c);
                    temp = 0;
                    len1--;
                    len2--;
                }
            }
            if(temp==1)
            {
                sb.Append(temp);
            }
            char[] s=sb.ToString().ToCharArray();
            for(int i=0;i<s.Length/2;i++)
            {
                char c=s[i];
                  s[i]=s[s.Length - 1 - i];
                s[s.Length - 1 - i] = c;
            }
            return new string(s);
        }

        /// <summary>
        /// leet 20.有效的括号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            Stack<char> stack1=new Stack<char>();
            for(int i = 0; i < s.Length; i++)
            {
                
                if(s[i]=='('||s[i]=='['||s[i]=='{')
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
            if(stack1.Count == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// leet 461.汉明距离
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistance(int x, int y)
        {
            //int distance = 0;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((x & (1 << i)) != (y & (1 << i)))
            //    {
            //        distance += 1;
            //    }
            //}
            //return distance;

            int distance = x^y;
            int count = CountBitsdigui(distance);
            return count;
        }

        /// <summary>
        /// leet 338.比特位计数
        /// 公式 x&(x-1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CountBits(int n)
        {
            int[] result = new int[n+1];
            for(int i= 0; i <= n; i++)
            {
                //result[i] = result[i&(i-1)]+1;
                //result[i] = CountBitsdigui(i);
                result[i] = (i&1)==1?result[i-1]+1:result[i>>1];
            }
            return result;
        }
        private static int CountBitsdigui(int n)
        {
            if (n == 0)
                return 0;
            int temp = n & (n - 1);
            temp = CountBitsdigui(temp) + 1;
            return temp;
        }


        /// <summary>
        /// leet 136.只出现一次的数字
        /// 异或操作，出现两次的数字被异或为0 A^A=0 A^A^B=B
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for(int i=0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }


        #region 二分查找   循环迭代 或 递归
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while(start <= end)
            {
                int mid=(start+end)/2;
                if(target<nums[mid])
                {
                    end = mid - 1;
                }
                else if(target>nums[mid])
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
        private int Searchdigui(int[] nums,int start,int end,int target)
        {
            int mid = (start + end) / 2;
            if(start<=end)
            {
                if(target<nums[mid])
                {
                    return Searchdigui(nums,start,mid-1,target);
                }
                else if(target>nums[mid])
                {
                    return Searchdigui(nums,mid+1,end,target);
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
        #region 顺序查找
        public static void shunxu()
        {

        }

        #endregion

        #region 冒泡排序
        /// <summary>
        /// 冒泡排序  递增
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static void maopao(int[] nums)
        { 
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j=0;j<nums.Length-1-i;j++)
                {
                    if (nums[j] >= nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
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
        public static void xuanze(int[] nums)
        {
            for(int i=0;i<nums.Length;i++)
            {
                int count = i;
                int max =nums[i];
                for (int j=i;j<nums.Length;j++)
                {
                    if(max <= nums[j])
                    {
                        max=nums[j];
                        count = j;
                    }
                }
                int temp=nums[i];
                nums[i]=nums[count];
                nums[count] = temp;
            }
        }
        #endregion

        #region 插入排序
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="nums"></param>
        public static void charu(int[] nums)
        {
            for(int i=0;i<nums.Length-1;i++)
            {
                for(int j=0;j<i+1;j++)
                {
                    if(nums[i+1]<nums[j])
                    {
                        int temp = nums[i + 1];
                        for(int k=i;k>=j;k--)
                        {
                            nums[k+1]=nums[k];
                        }
                        nums[j] = temp;
                    }
                }
            }
        }
        #endregion

        #region 快速排序 对冒泡排序改进
        public static void kuaisu(int[] nums,int left,int right)
        {
            if(left<right)
            {
                int i=left;
                int j=right;
                int start=nums[i];
                while(i<j)
                {
                    while (start <= nums[j]&&i<j) j--;
                    nums[i]=nums[j];
                    while (start >= nums[i]&&i<j) i++;
                    nums[j]=nums[i];
                }
                nums[i] = start;
                kuaisu(nums,i+1,right);
                kuaisu(nums,left,i-1);
            }
        }
        #endregion

        #region 希尔排序  分组插入排序，直至组间距为1
        public static void xier(int[] nums,int gap)
        {
            for(int i=0;i<nums.Length;i+=gap)
            {
                if (i+gap < nums.Length)
                {
                    for (int j = 0; j < i+gap; j+=gap)
                    {
                        if (j < nums.Length)
                        {
                            if (nums[i + gap] < nums[j])
                            {
                                int temp = nums[i + gap];
                                for (int k = i; k >= j; k-=gap)
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
        public static void guibing(int[] nums,int start,int end)
        {
            //int[] a=new int[]
            //if()


        }

        #endregion
    }

    #endregion

    
}
