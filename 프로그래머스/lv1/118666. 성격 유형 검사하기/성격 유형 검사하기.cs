using System;
using System.Collections.Generic;
using System.Linq;


public class Solution 
{
    public string solution(string[] survey, int[] choices)
    {
        string answer = "";
        //[1] choices에 따라 유형별 점수 부여
        int[] scores = {3, 2, 1, 0, 1, 2, 3};
        var results = new Dictionary<string, int>()
        {
            { "R", 0 }, { "T", 0 },
            { "C", 0 }, { "F", 0 },
            { "J", 0 }, { "M", 0 },
            { "A", 0 }, { "N", 0 }
        };
        
        //choice값에 따라.. survey를 쪼개고.. 
        for(int i = 0; i < choices.Length; i++)
        {
            string first = survey[i].Substring(0, 1);
            string second = survey[i].Substring(1, 1);
            if(choices[i]<4)
            {
                results[first] += scores[choices[i] - 1];
            }
            
            else if (choices[i] > 4)
            {
                results[second] += scores[choices[i] - 1];
            }
        }
        
        //[2]dictionary안에서 value값 비교해소 answer 출력
        // 둘 다 0일 때는 사전적으로 앞에 있는 놈.
        List<string> dKeys = new List<string>();
        List<int> dValues = new List<int>();
        dKeys = results.Keys.ToList();
        dValues = results.Values.ToList();
        
        for (int i = 1; i < results.Count; i += 2)
        {
            
            if (dValues[i] == dValues[i - 1])
            {
                answer += dKeys[i - 1];
            }
            else if (dValues[i] > dValues[i - 1])
            {
                answer += dKeys[i];
            }
            else
            {
                answer += dKeys[i - 1];
            }
            
        } 
        return answer;
    }
}