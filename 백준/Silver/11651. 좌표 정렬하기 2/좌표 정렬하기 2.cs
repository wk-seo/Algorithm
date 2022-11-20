using System.Collections.Generic;
using System.Text;

int n = int.Parse(Console.ReadLine());
List<int[]> list = new List<int[]>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    list.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
}

list = list.OrderBy(x => x[1]).ThenBy(x => x[0]).ToList();
foreach (var x in list)
{
    sb.AppendLine(x[0] + " " + x[1]);
}
Console.WriteLine(sb.ToString());