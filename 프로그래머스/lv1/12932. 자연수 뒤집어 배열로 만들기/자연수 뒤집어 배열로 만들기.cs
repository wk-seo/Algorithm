using System;

public class Solution 
{
    public int[] solution(long nn) 
    {
       string m = nn.ToString();
        int l = m.Length-1;

        string[] temp = new string[m.Length];
        for (int i = 0; i < m.Length; i++)
        {
            temp[i] = m.Substring(l, 1);
            l--;
        }
        
        int[] answer = Array.ConvertAll(temp, int.Parse);
        return answer;
    }
}