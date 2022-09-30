using System;

public class Solution {
    public int solution(int[] d, int budget)
    {
        int answer = 0;
        int tot = 0;
        //요청값 오름차순 정렬
        Array.Sort(d);
        
        for(int i = 0; i < d.Length; i++)
        {
            tot += d[i];
        }
        
        
        if(tot < budget)
            answer = d.Length;
        
        else
        {
            for (int i = 0; budget > 0; i++)
            {
                budget -= d[i];
                if(budget >= 0)
                    answer++;
            }
        }
        
        return answer;
    }
//초기 생각
//case1: 총합이 예산보다 작음 -> answer = d.length
//case2: 총합이 예산보다 큼
//  1. 원소들을 d.Length-1개씩 더해봐야댐
//  2. 만약 더한 값이 예산보다 작고, 그 차이가 d 원소의 최솟값보다 작다면 -> answer = d.lenght-1 근데 그럴 일이 있나? 
// -> answer를 요청 부서 수 전체로 두고 시작해서 못주면 빼는 방식
// -> 이렇게되면 예산이 적어 특정 부서를 제외할 때 우선순위 세워야함 -> 복잡
        
//남의 풀이
//다 상관없이, 요청값이 작은 순서대로 예산에서 빼줌. 
//answer는 지원한 부서의 수니까 0으로 초기화
//  -> 각 부서에서 예산을 사용할 때 마다 ++
//와 진짜 간단하다 짱
    
//남의풀이대로하니 시간초과남
//지원 요청 값 합해서 budget보다 작으면 바로 answer반환으로 수정
}