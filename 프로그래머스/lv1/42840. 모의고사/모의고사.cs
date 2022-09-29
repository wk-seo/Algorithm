using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] answers) 
    {        
           int l = answers.Length;
        int c1 = 0, c2 = 0, c3 = 0;
        int a = 1, b = 2, c = 3;
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] arr3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        for (int i = 0; i < answers.Length; i++)
        {
            if (arr1[i % 5] == answers[i])
                c1++;

            if (arr2[i % 8] == answers[i])
                c2++;

            if (arr3[i % 10] == answers[i])
                c3++;
        }

        List<int> temp = new List<int>();
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            if (c1 == c2 && c2 == c3)
            {
                temp.Add(a);
                temp.Add(b);
                temp.Add(c);
            }

            else if (c1 == c2 && c2 > c3)
            {
                temp.Add(a);
                temp.Add(b);
            }

            else if (c1 == c3 && c2 < c3)
            {
                temp.Add(a);
                temp.Add(c);
            }

            else if (c2 == c3 && c1 < c3)
            {
                temp.Add(b);
                temp.Add(c);
            }

            else if (c1 > c2 && c1 > c3)
            {
                temp.Add(a);
            }
            else if (c2 > c1 && c2 > c3)
            {
                temp.Add(b);
            }

            else if (c3 > c1 && c3 > c2)
            {
                temp.Add(c);
            }
            int[] answer = temp.ToArray();


            foreach (int an in answer)
            {
                Console.WriteLine(an);
            }
            
            return answer;
    }
}