using System.Linq;
using System.Collections.Generic;

public class MainApp{
    
    static int hd = 0;
    
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string[] DNAs = new string[inputs[0]];
        string[,] tot = new string[inputs[0], inputs[1]];
        string answer = "";
        //int[] counts = new int[inputs[0]];
        for (int i = 0; i < inputs[0]; i++)
        {
            DNAs[i] = Console.ReadLine();
            for (int j = 0; j < inputs[1]; j++)
            {
                tot[i, j] = DNAs[i].Substring(j, 1);
            }
        }

        for (int i = 0; i < inputs[1]; i++)
        {
            List<string> temp = new List<string>();
            for (int j = 0; j < inputs[0]; j++)
            {
                temp.Add(tot[j, i]);
            }
            temp.Sort();
            answer+=Mode(temp.ToArray());
        }

        Console.WriteLine(answer);
        Console.WriteLine(hd);
    }
    
    public static string Mode(string[] arr)
    {
        Dictionary<string, int> count = new Dictionary<string, int>()
        {
            { "A", 0 }, { "T", 0 }, { "G", 0 }, { "C", 0 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            if (count.ContainsKey(arr[i]))
            {
                count[arr[i]]++;
            }
        }
        count = count.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
        string a = count.OrderByDescending(x => x.Value).First().Key;

        hd += count.Sum(x => x.Value) - count[a];

        return a;
    }
    
}