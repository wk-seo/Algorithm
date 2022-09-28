using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) 
    {
        int min = int.MaxValue;
        int m_index = 0;
        int l = arr.Length;
        int[] answer = new int[arr.Length-1];
        
        if (l > 1)
        {
            for (int i = 0; i < l; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    m_index = i;
                }
            }

            List<int> tempList = new List<int>();
            
            tempList.AddRange(arr);
            tempList.RemoveAt(m_index);

            answer = tempList.ToArray();
        }

        else
        {
            Array.Resize(ref answer, 1);
            answer[0] = -1;
        }
        //test
        // foreach (int a in answer)
        // {
        //     Console.WriteLine(a);
        // }
        return answer;
        
    }
}