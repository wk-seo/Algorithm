using System.Collections.Generic;

int[] mn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Dictionary<string, int> dic = new Dictionary<string, int>();
for (int i = mn[0]; i <= mn[1]; i++)
{
    string temp = "";
    for (int j = 0; j < i.ToString().Length; j++)
    {
        temp += (" "+Convert(i.ToString()[j]));
    }
    dic.Add(temp, i);
}

dic = dic.OrderBy(x => x.Key).ToDictionary(x=>x.Key, y=>y.Value);
int[] arr = dic.Values.ToArray();
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+" ");
    if((i+1)%10==0) Console.WriteLine();
}

string Convert(char c)
{
    string[] str =
    {
        "zero", "one", "two", "three", "four",
        "five", "six", "seven", "eight", "nine"
    };
    return str[int.Parse(c.ToString())];
}