using System.Collections.Generic;
using System.Text;

int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Dictionary<string, string> dic = new Dictionary<string, string>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < nm[0]; i++)
{
    string[] temp = Console.ReadLine().Split();
    dic.Add(temp[0], temp[1]);
}

for (int i = 0; i < nm[1]; i++)
{
    sb.AppendLine(dic[Console.ReadLine()]);
}

Console.WriteLine(sb.ToString());