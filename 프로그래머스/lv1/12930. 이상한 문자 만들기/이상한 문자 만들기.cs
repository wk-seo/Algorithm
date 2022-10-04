using System;

public class Solution 
{
    public string solution(string s) 
    {        
        bool isStart = true;
        string[] str = new string[s.Length];
        string answer = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            str[i] = s.Substring(i,1);

            if(isStart)
            {
                str[i] = str[i].ToUpper();
                isStart = false;
            }
            
            else
            {
                str[i] = str[i].ToLower();
                isStart = true;
            }
            
            if(str[i] == " ")
            {
                isStart = true;
            }
            
            answer += str[i];
        }
        
        return answer;
    }
}
               
