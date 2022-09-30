using System;

public class Solution {
    public int solution(int n) 
    {

        int count = n-1;
        
        for(int i = 3; i <= n; i++)
        {
            if(i%2 == 0)
                count--;
                
            else
            {
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i%j == 0)
                    {
                        count--;
                        break;//소수 아님
                    }
                }
            }
        }
            
        int answer = count;
        return answer;
    }
}