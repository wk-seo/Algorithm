using System;

public class Solution {
    public int solution(string s)
    {
        string [] words = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        for(int i = 0; i < words.Length; i++)
        {
            if(s.Contains(words[i]))
            {
                s = s.Replace(words[i], i.ToString());
            }
        }
        
        int answer = int.Parse(s);
        return answer;
    }
}