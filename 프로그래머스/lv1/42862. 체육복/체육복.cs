using System;
using System.Linq;

public class Solution 
{
    public int solution(int n, int[] lost, int[] reserve) 
    {
        //answer = 체육수업을 들을 수 있는 학생 수
        int answer = n-lost.Length;
        
        //여벌이 있고 잃어버린 경우 먼저 검사. reserve에서 지워버리기.(스레기값)
        for(int i =0; i<lost.Length; i++)
        {
            if(reserve.Contains(lost[i]))
            {
                reserve[Array.IndexOf(reserve, lost[i])] = 32;
                //여벌이 있고 잃어버린 경우에도 answer++해주어야함.
                answer++;
                lost[i] = 34; //그리고 자기 것 입으니 빌려줄 사람 검사는 안해야쥐
                continue;
            }
        }
        
        Array.Sort(lost);
        Array.Sort(reserve);
        
        for(int i = 0; i<lost.Length; i++)
        {
            if(reserve.Contains(lost[i]-1))
            {
                reserve[Array.IndexOf(reserve, lost[i]-1)] = 32;
                answer++;
                continue;
            }
            
            else if(reserve.Contains(lost[i]+1))
            {
                reserve[Array.IndexOf(reserve, lost[i]+1)] = 32;
                answer++;
                continue;
            }
            
        }
        
        return answer;
    }
}