using System;

public class Solution 
{
    public int solution(int n) 
    {
        int x = 1;
        while(n%x != 1)
        {
            x++;
        }
        
        int answer = x;
        return answer;
    }
}