using System;
using System.Collections.Generic;

public class MainApp
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>();
        for (int i = 1; i < 10000; i++)
        {
            int j = Produce(i);
            if (j < 10000)
            {
                arr.Add(j);
            }
        }
        

        List<int> arr2 = new List<int>();

        for (int i = 1; i < 10000; i++)
        {
            arr2.Add(i);
        }

        arr2 = arr2.Except(arr).ToList();

        foreach (int sn in arr2)
        {
            Console.WriteLine(sn);
        }
    }
    
    public static int Produce(int a)
    {
        int num = 0, temp = 0;
        int tempA = a;

        while (tempA > 0)
        {
            temp += tempA % 10;
            tempA /= 10;
        }
        num = a+temp;

        return num;
    }
}