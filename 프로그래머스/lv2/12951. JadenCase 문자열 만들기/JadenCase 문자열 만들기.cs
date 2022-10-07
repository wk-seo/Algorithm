using System;
using System.Text;

public class Solution {
    public string solution(string s) 
    {
        bool isStart = true;
        int checknum = 0;
        string[] ss = new string[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            ss[i] = s.Substring(i, 1);
        }
        for(int i = 0; i < ss.Length; i++)
        {
            if(isStart)
            {
                if(!int.TryParse(ss[i], out checknum)) ss[i] = ss[i].ToUpper();
                isStart = false;
            }
                
            else
            {
                ss[i] = ss[i].ToLower();
            }
            
            if(ss[i] == " ") isStart = true;

        }
        
        string answer = string.Concat(ss);
        return answer;
    }
}