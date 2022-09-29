using System;
using System.Numerics;

public class Solution 
{
    public long solution(int n)
    {
        long answer = 1;
        long a = 1, b = 2;

        if (n == 1 || n==2)
         answer = n;
        
        else
        {
            for (long i = 3; i <= n; i++)
            {
                answer = (a + b) % 1234567;
                a = b;
                b = answer;
            }
            
        }
        return answer;
    }
}