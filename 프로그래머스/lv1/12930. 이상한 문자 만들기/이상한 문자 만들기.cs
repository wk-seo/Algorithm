using System;

public class Solution 
{
    public string solution(string s) 
    {        
        bool isUpper = true;
        string[] str = new string[s.Length];
        string answer = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            str[i] = s.Substring(i,1);

            if(isUpper)
            {
                str[i] = str[i].ToUpper();
                isUpper = false;
            }
            
            else
            {
                str[i] = str[i].ToLower();
                isUpper = true;
            }
            
            if(str[i] == " ")
            {
                isUpper = true;
            }
            
            answer += str[i];
        }
        
        return answer;
    }
}
               
