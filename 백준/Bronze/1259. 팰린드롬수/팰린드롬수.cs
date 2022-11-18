using System.Text;

string s = "";
StringBuilder sb = new StringBuilder();
while (s != "0")
{
    s = Console.ReadLine();
    bool check = true;
    if (s == "0") break;
    for (int i = 0; i <= s.Length/2; i++)
    {
        if (s[i] != s[s.Length - (i+1)])
        {
            check = false;
            break;
        }
    }
    sb.AppendLine(check ? "yes" : "no");
}
Console.WriteLine(sb.ToString());