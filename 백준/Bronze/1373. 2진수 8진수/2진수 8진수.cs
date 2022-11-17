using System.Text;
StringBuilder sb = new StringBuilder();
string s = Console.ReadLine();
while (s.Length % 3 != 0)
{
    s = ("0" + s);
}
for (int i = 0; i < s.Length; i += 3)
{
    int num = (s[i] - '0') * 4 + (s[i + 1] - '0') * 2 + (s[i + 2] - '0') * 1;
    sb.Append(num);
}
Console.WriteLine(sb.ToString());