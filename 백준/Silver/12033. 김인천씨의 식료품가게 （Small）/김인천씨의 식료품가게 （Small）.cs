using System;
using System.Collections.Generic;

public class MainApp
{
    public static void Main(string[] args)
    {
        int testCaseNum = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCaseNum; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            input = Discount(input);
            Array.Sort(input);
            Console.Write($"Case #{i+1}: ");
            foreach (int a in input)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
        }
    }


    public static int[] Discount(int[] arr)
    {
              List<int> temp = new List<int>();
        List<int> origin = arr.ToList();

        origin.Reverse();

        for (int i = 0; i < origin.Count; i++)
        {
            if (origin[i]%4==0 && origin.Contains((int)(origin[i]*0.75)))
            {
                origin.Remove((int)(origin[i]*0.75));
                temp.Add((int)(origin[i]*0.75));
            }
        }
        int[] answer = new int [temp.Count];
        answer = temp.ToArray();

        return answer;
    }
    
}