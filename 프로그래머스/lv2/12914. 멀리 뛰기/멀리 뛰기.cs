using System;
using System.Numerics;

public class Solution 
{
    public long solution(int n)
    {
        //[1] 반복문
        //%1234567를 answer구하고 했더니 오버플로우. 
        //자료형 바꾸고 난리 부르스를 췄는데 걍 더하자마자 나누면 간단. 조건을 준 이유가 있다.
        long answer = 1;
        long a = 1, b = 2;

        if (n == 1 || n==2)
         answer = n;
        
        else
        {
            for (int i = 3; i <= n; i++)
            {
                answer = (a + b) % 1234567;
                a = b;
                b = answer;
            }
        }

        Console.WriteLine(answer);
        return answer;
        
        //[2] 점화식(오버플로우. 얘도 answer에 바로 1234567나머지 구하면 괜찮으려나?)
            //ㄴ 안괜찮
        // int[] dp = new int[n];
        // dp[0] = 1;
        // dp[1] = 2;
        // dp[2] = 3;
        //
        // for (int i = 3; i <= n-1; i++)
        // {
        //     dp[i] = dp[i-1]+dp[i-2];
        // }
        //
        // long answer = dp[n-1]%1234567;
        //
        // Console.WriteLine(answer);
        // return answer;



        // List<int> dp = new List<int>();
        //
        // dp.Add(1);
        // dp.Add(2);
        // dp.Add(3);
        // dp.Add(5);
        //
        // for (int i = 4; i <= n; i++)
        // {
        //     dp.Add(dp[i-1]+dp[i-2]);
        // }
        //
        // long answer = (dp[n-2]+dp[n-3])%1234567;
        // Console.WriteLine(answer);
        // return answer;
    }
}
