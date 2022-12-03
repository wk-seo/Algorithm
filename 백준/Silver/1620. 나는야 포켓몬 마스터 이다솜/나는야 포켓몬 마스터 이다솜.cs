using System.Text;
using System.Collections.Generic;

int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];
Dictionary<int, string> num = new Dictionary<int, string>();
Dictionary<string, int> name = new Dictionary<string, int>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    string temp = Console.ReadLine();
    num.Add(i+1, temp);
    name.Add(temp, i+1);
}

for (int i = 0; i < m; i++)
{
    string s = Console.ReadLine();
    if (Int32.TryParse(s, out int a))
    {
        sb.AppendLine(num[a]);
    }
    else
    {
        sb.AppendLine(name[s].ToString());
    }
}

Console.WriteLine(sb.ToString());