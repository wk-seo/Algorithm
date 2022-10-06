using System;

public class Solution {
    public string[] solution(string[] strings, int n) 
    {
        string[] chars = new string[strings.Length];
        int l = strings.Length;
        for (int i = 0; i < strings.Length; i++)
        {
            chars[i] = strings[i].Substring(n, 1);
            strings[i] = chars[i] + strings[i];
        }

        Array.Sort(strings);
        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = strings[i].Substring(1);
        }
        
        string[] answer = strings;
       

        return answer;
    }
}