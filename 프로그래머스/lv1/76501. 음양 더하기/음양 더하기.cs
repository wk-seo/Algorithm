using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) 
    {
        
        int answer = 0;

        for (int i = 0; i < signs.Length; i++)
        {
            if(!signs[i])
            absolutes[i] *= -1;
        }

        for (int i = 0; i < signs.Length; i++)
        {
            answer += absolutes[i];
        }

        return answer;
    }
}