using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        //answer[0] = 최고순위, answer[1] = 최저순위
        
        int zeroCount = 0;
        int rightCount = 0;
        
        foreach(int lotto in lottos )
        {
            //알 수 없는 번호의 개수를 센다.
            if(lotto == 0)
            {
                zeroCount++;
                    continue;
            }
            
            //당첨번호랑 같은 내 번호의 수
            foreach(int winNum in win_nums)
            {   
                if(lotto == winNum)
                {
                    rightCount++;
                    break;
                }
            }
        }
        
        answer[0] = 7-(zeroCount+rightCount);
        
        //최저등수
        answer[1] = 7-rightCount;
        
        if(answer[1]>= 7)
        {
            answer[1] = 6; //rightcount가 0이면 낙첨(6등)
        }
        
        if(answer[0]>=7)
        {
            answer[0] = 6;
        }
        
        return answer;
    }
}