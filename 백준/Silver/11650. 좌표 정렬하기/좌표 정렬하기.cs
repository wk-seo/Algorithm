using System.Collections.Generic;
using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
List<int[]> arr = new List<int[]>();

for (int i = 0; i < n; i++)
{
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    arr.Add(temp);
}

var b = arr.OrderBy(x => x[1]);
var c = b.OrderBy(x => x[0]);
foreach (var item in c)
{
    sb.AppendLine(item[0] + " " + item[1]);
}

Console.WriteLine(sb.ToString());