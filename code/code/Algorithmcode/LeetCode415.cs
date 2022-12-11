using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.Algorithmcode
{
    public class LeetCode415
    {


        /// <summary>
        /// leet 415.字符串相加
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int len1 = num1.Length - 1;
            int len2 = num2.Length - 1;
            int temp = 0;
            for (int i = 0; i < Math.Max(num1.Length, num2.Length); i++)
            {

                if (len1 < 0)
                {
                    for (int j = len2; j >= 0; j--)
                    {
                        int c = num2[j] - '0' + temp;
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
                else if (len1 < 0 && len2 < 0)
                    break;
                int x = num1[len1] - '0';
                int y = num2[len2] - '0';
                if (x + y + temp >= 10)
                {
                    int c = x + y - 10 + temp;
                    sb.Append(c);
                    temp = 1;
                    len1--;
                    len2--;
                }
                else
                {
                    int c = x + y + temp;
                    sb.Append(c);
                    temp = 0;
                    len1--;
                    len2--;
                }
            }
            if (temp == 1)
            {
                sb.Append(temp);
            }
            char[] s = sb.ToString().ToCharArray();
            for (int i = 0; i < s.Length / 2; i++)
            {
                char c = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = c;
            }
            return new string(s);
        }
    }
}
