using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = 0;
        long currentPrice = 0;
        
        for(int i = 1; i <= count; i++)
        {
            currentPrice += price*i;
        }
        
        answer = money - currentPrice;
        
        if(answer>0) answer = 0;
        
        else answer *= -1;
        
        return answer;
    }
}