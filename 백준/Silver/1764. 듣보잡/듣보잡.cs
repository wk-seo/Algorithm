using System.Collections.Generic;
int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];
Dictionary<string, int> heard = new Dictionary<string, int>();
Dictionary<string, int> hs = new Dictionary<string, int>();

for (int i = 0; i < n+m; i++)
{
    if (i < n)
    {
        string s = Console.ReadLine();
        heard.Add(s, 1);
    }
    else
    {
        string ss = Console.ReadLine();
        if (!heard.TryAdd(ss, 1)) 
            hs.Add(ss, 1);
    }
}

List<string> list = hs.Keys.ToList();
list.Sort();
Console.WriteLine(hs.Count);
foreach (string s in list)
{
    Console.WriteLine(s);
}