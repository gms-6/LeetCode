using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode6257
    {
        /// <summary>
        /// leet 6257. 删除每行中的最大值
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int DeleteGreatestValue(int[][] grid)
        {
            int totalmax = 0;
            for (int n = 0; n < grid[0].Length; n++)
            {
                int[] max = new int[grid.Length * grid[0].Length / grid[0].Length];
                for (int i = 0; i < grid.Length * grid[0].Length / grid[0].Length; i++)   //行数
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
    }
}
