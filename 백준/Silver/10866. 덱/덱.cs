using System.Collections.Generic;
using System.Text;
int n = int.Parse(Console.ReadLine());
List<string> d = new List<string>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
    if (command.Length == 2)
    {
        int temp = 0;
        bool result = int.TryParse(command[1], out temp);
        if (result)
        {
            switch (command[0])
            {
                case "push_back":
                    d.Add(command[1]);
                    break;
                case "push_front":
                    d.Insert(0, command[1]);
                    break;
            }
        }
    }
    else
    {
        switch (command[0])
        {
            case "pop_front":
                if (d.Count == 0) sb.AppendLine("-1");
                else
                {
                    sb.AppendLine(d[0]);
                    d.Remove(d[0]);
                }
                break;
            case "pop_back":
                if (d.Count == 0) sb.AppendLine("-1");
                else
                {
                    sb.AppendLine(d[d.Count-1]);
                    d.RemoveAt(d.Count-1);
                }
                break;
            case "size":
                sb.AppendLine(d.Count.ToString());
                break;
            case "empty":
                if (d.Count == 0) sb.AppendLine("1");
                else  sb.AppendLine("0"); 
                break;
            case "front":
                if (d.Count == 0) sb.AppendLine("-1");
                else  sb.AppendLine(d[0]); 
                break;
            case "back":
                if (d.Count == 0) sb.AppendLine("-1");
                else  sb.AppendLine(d[d.Count-1]); 
                break;
        }
    }
}

Console.Write(sb.ToString());