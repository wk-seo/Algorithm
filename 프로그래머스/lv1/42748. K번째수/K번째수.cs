using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) 
    {
        int i, j, k;
        
        int num = commands.GetLength(0);
        
        int[] answer = new int[num];

        for (int l = 0; l < num; l++)
        {
            i = commands[l, 0];
            j = commands[l, 1];
            k = commands[l, 2];
            
            int[] temp = new int[j-i+1];

            Array.Copy(array, i-1, temp, 0, j-i+1);
            Array.Sort(temp);
            answer[l] = temp[k - 1];
        }

        foreach (int a in answer)
        {
            Console.WriteLine(a);
        }

         return answer;
    }
}