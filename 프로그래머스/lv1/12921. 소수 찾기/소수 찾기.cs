using System;

public class Solution {
    public int solution(int n) 
    {
        //int count = 소수의 개수
            //모든 수가 소수라고 가정하고 시작(n개) 
            //1 제외, n-1로 초기화
            //ㄴ0부터 소수일 경우 더하면 소수 판별식이 복잡해짐
        int count = n-1;
        
        //2 무조건 포함이니, 3부터 n까지 소수 판별.
        for(int i = 3; i <= n; i++)
        {
            //짝수면 소수가 아니기에 바로 제외
            if(i%2 == 0)
                count--;
                
            else
            {
                //n을 2부터 n의 제곱근까지 나눠줌
                //한 번이라도 나누어 떨어진다면 소수가 아님.
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
