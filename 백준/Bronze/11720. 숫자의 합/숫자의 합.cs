int n = int.Parse(Console.ReadLine());
string s = Console.ReadLine();
int answer = 0;
for (int i = 0; i < n; i++)
{
    string ss = s.Substring(i, 1);
    answer += int.Parse(ss);
}
Console.WriteLine(answer);