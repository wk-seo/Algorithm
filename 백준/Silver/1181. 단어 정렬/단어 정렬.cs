using System.Collections.Generic;
using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
SortedDictionary<string, int> check = new SortedDictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    if(!check.TryAdd(s, s.Length));
}

var asc = check.OrderBy(x => x.Value);
foreach (var s in asc)
{
    sb.AppendLine(s.Key);
}
Console.WriteLine(sb.ToString());
