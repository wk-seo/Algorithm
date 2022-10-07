using System;

public class Solution {
    public string solution(string s) 
    {
        string[] ss = s.Split();
        string max = Int32.MinValue.ToString();
        string min = Int32.MaxValue.ToString();
        for(int i = 0; i < ss.Length; i++)
        {
            if(Convert.ToInt32(max) < Convert.ToInt32(ss[i])) max = ss[i];
            if(Convert.ToInt32(min) > Convert.ToInt32(ss[i])) min = ss[i];
        }
            
        string answer = min + " " + max;
        return answer;
    }
}