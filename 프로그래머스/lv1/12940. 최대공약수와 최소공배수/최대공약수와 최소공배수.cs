using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];
        int[] inputs = new int[2];

        if(n > m)
        {
            inputs[0] = m;
            inputs[1] = n;
        }
        else
        {
            inputs[0] = n;
            inputs[1] = m;
        }
        
        List<int> smalls = new List<int>();
        List<int> bigs = new List<int>();
        List<int> common = new List<int>();
        int max = 1;
        
        for(int i = 1; i <= inputs[1]; i++)
        {
            if (inputs[0] % i == 0) 
                smalls.Add(i);
            
            if(inputs[1]%i==0) 
                bigs.Add(i);
        }
        
        for(int i = 0; i < bigs.Count; i++)
        {
            for(int j = 0; j < smalls.Count; j++)
            {
                if(bigs[i] ==  smalls[j])
                    common.Add(smalls[j]);
            }
        }
        
        for(int i = 0; i < common.Count; i++)
        {
            if(max<common[i])
                max = common[i];
        }
        
        answer[0] = max;
        answer[1] = max*(inputs[1]/max)*(inputs[0]/max);

        return answer;
    }
}