using System;

class MainApp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            if (Han(i))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
    
    static bool Han(int num)
        {
        bool isHan = true;

        string snum = num.ToString();

        string[] sarr = new string[snum.Length];
        for (int i = 0; i < snum.Length; i++)
        {
            sarr[i] = snum.Substring(i, 1);
        }
        
        int[] arr = Array.ConvertAll(sarr, int.Parse);
        int l = arr.Length;

        if (l <= 2)
        {
            isHan = true;
        }
        
        else
        {
            for (int i = l-1; i >= 2; i--)
            {
                if (arr[i] - arr[i - 1] != arr[i - 1] - arr[i - 2])
                {
                    isHan = false;
                    return isHan;
                }
            }
        }

        return isHan;
    }
}