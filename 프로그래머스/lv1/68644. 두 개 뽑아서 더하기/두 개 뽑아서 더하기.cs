using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) 
    {
        List <int> sums = new List<int>();
        
        for(int i = 0; i < numbers.Length-1; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                sums.Add(numbers[i]+numbers[j]);
            }
        }
        
        int[] answer = sums.Distinct().ToArray();
        Array.Sort(answer);
        return answer;
    }
}