using System.Collections.Generic;
using System.Text;

int n = int.Parse(Console.ReadLine());
SortedSet<int> hs = new SortedSet<int>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    hs.Add(int.Parse(Console.ReadLine()));
}
foreach (int s in hs)
{
    sb.AppendLine(s.ToString());
}
Console.WriteLine(sb.ToString());