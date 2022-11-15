using System.Collections.Generic;

string s = Console.ReadLine();
Dictionary<string, int> dic = new Dictionary<string, int>();
char[] spell = s.ToCharArray();
for (int i = 0; i < s.Length; i++)
{
    if(!dic.TryAdd(spell[i].ToString().ToLower(), 1))
        dic[spell[i].ToString().ToLower()]++;
}

List<int> temp = dic.Values.ToList();
temp.Sort();
if(temp.Count == 1) Console.WriteLine(spell[0].ToString().ToUpper());
else if(temp[temp.Count-1]==temp[temp.Count-2])
    Console.WriteLine("?");
else
    Console.WriteLine(dic.OrderByDescending(x=>x.Value).First().Key.ToUpper());