// https://leetcode.com/problems/roman-to-integer/description/
using System.Collections.Generic;

namespace solution.Easy
{
    public class RomanToInteger
    {
        private static readonly Dictionary<string, int> _table1 = new()
        {
            {"I" , 1},
            {"V" , 5},
            {"X" , 10},
            {"L" , 50},
            {"C" , 100},
            {"D" , 500},
            {"M" , 1000},
        };
        private static readonly Dictionary<string, int> _table2 = new()
        {
            {"IV" , 4},
            {"IX" , 9},
            {"XL" , 40},
            {"XC" , 90},
            {"CD" , 400},
            {"CM" , 900},
        };
        public static int Solution(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 == s.Length)
                {
                    result += _table1[s[i].ToString()];
                    break;
                }
                string temp = s[i].ToString() + s[i + 1].ToString();
                if (_table2.ContainsKey(temp))
                {
                    result += _table2[temp];
                    i++;
                    continue;
                }
                result += _table1[s[i].ToString()];
            }

            return result;
        }
    }
}