using System.Collections.Generic;
using System.Text;

List<string> q = new List<string>();
StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] temps = Console.ReadLine().Split();

    switch (temps[0])
    {
        case "pop":
            if (q.Count != 0)
            {
                string a = q[0];
                q.Remove(a);
                sb.AppendLine(a);
            }
            else sb.AppendLine("-1");

            break;
        case "size":
            sb.AppendLine(q.Count.ToString());
            break;
        case "empty":
            if (q.Count == 0) sb.AppendLine("1");
            else sb.AppendLine("0");
            break;
        case "front":
            if (q.Count != 0) sb.AppendLine(q[0]);
            else sb.AppendLine("-1");
            break;
        case "back":
            if (q.Count != 0) sb.AppendLine(q[q.Count - 1]);
            else sb.AppendLine("-1");
            break;
        default:
            q.Add(temps[1]);
            break;
    }
}

Console.WriteLine(sb.ToString());