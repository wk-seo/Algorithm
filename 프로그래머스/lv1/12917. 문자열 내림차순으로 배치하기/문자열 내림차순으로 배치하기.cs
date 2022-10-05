using System;
using System.Collections.Generic;

    public class Solution
    {
        public string solution(string s)
        {
            char[] chr = s.ToCharArray();
            string answer = "";
            
            Array.Sort(chr);
            Array.Reverse(chr);
            
            for (int i = 0; i < chr.Length; i++)
            {
                answer += chr[i];
            }

            return answer;
        }
    }