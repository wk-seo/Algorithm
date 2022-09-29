using System;


public class Solution {
    public string solution(string s) 
    {
        string[] str = new string[s.Length];
        string answer = "";
        for(int i = 0; i < s.Length; i++)
        {
            str[i] = s.Substring(i, 1);            
        }
        
        if(s.Length % 2 == 0)
            answer = str[s.Length/2 -1]+str[s.Length/2];
    
        else
            answer = str[s.Length/2];
            
        return answer;
    }
}