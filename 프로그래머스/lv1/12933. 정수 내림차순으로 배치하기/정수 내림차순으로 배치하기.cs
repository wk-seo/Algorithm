using System;


public class Solution 
{
    public long solution(long n) 
    {
        string m = n.ToString();
        string o = "";
        
        string[] temp = new string[m.Length];
        for (int i = 0; i < m.Length; i++)
        {
            temp[i] = m.Substring(i, 1);
        }

        int[] temp2 = Array.ConvertAll(temp, Int32.Parse);
        Array.Sort(temp2);
        Array.Reverse(temp2);
        

        for (int i = 0; i < m.Length; i++)
        {
            o += $"{temp2[i]}";
        }
        
        long answer = long.Parse(o);
        Console.WriteLine(answer);
        return answer;
    }
}