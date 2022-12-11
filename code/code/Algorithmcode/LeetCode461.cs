using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode461
    {

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

            int distance = x ^ y;
            int count = CountBitsdigui(distance);
            return count;
        }
        private int CountBitsdigui(int n)
        {
            if (n == 0)
                return 0;
            int temp = n & (n - 1);
            temp = CountBitsdigui(temp) + 1;
            return temp;
        }
    }
}
