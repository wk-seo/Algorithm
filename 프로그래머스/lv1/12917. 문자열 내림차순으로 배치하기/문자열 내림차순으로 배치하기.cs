using System;
using System.Collections.Generic;

    public class Solution
    {
        public string solution(string s)
        {
            char[] chr = new char[s.Length];
            string answer = "";
            List<char> upper = new List<char>();
            List<char> lower = new List<char>();
            List<char> temps = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                chr[i] = char.Parse(s.Substring(i, 1));
                int a = Convert.ToInt32(chr[i]);
                if(a >= 65 && a <= 90) upper.Add(chr[i]);
                else if(a >= 97 && a <= 122) lower.Add(chr[i]);
            }

            upper.Sort();
            upper.Reverse();
            lower.Sort();
            lower.Reverse();
            
            for (int i = 0; i < lower.Count; i++)
            {
                temps.Add(lower[i]);
            }

            for (int i = 0; i < upper.Count; i++)
            {
                temps.Add(upper[i]);
            }

            for (int i = 0; i < temps.Count; i++)
            {
                answer += temps[i];
            }

            return answer;
        }
    }