using System.Collections.Generic;
Dictionary<char, long> dic = new Dictionary<char, long>()
{
    { 'A', 10 }, { 'B', 11 }, { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 }
};
string s = Console.ReadLine();
long result = 0;
for (int i = 0; i < s.Length; i++)
{
    long temp = 0;
    if(dic.Keys.Contains(s[i]))
    {
        char a = s[i];
        temp = dic[a];
    }
    else
    {
        temp = long.Parse(s[i].ToString());
    }
    result = 16 * result + temp;
}
Console.WriteLine(result);