using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) 
    {
        int answer = 0;

        List<int> sams = new List<int>();
        
        while(true)
        {
            if(n==0) break;
            
            int d = n%3;
            sams.Add(d);
            n = n/3;
        }
        
        sams.Reverse();
        
        for(int i = 0; i < sams.Count; i++)
        {
            answer += (int)(sams[i]*Math.Pow(3, i));
        }
        
        return answer;
    }
}