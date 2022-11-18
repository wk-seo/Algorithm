using System.Text;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
List<Info> list = new List<Info>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    string[] temp = Console.ReadLine().Split();
    Info s = new Info(i, temp[0], temp[1]);
    list.Add(s);
}

var a = list.OrderBy(x => x.age).ThenBy(x => x.index);
foreach (var temp in a)
{
    sb.AppendLine(temp.age + " " + temp.name);
}

Console.Write(sb.ToString());


public class Info
{
    public int index;
    public int age;
    public string name;

    public Info(int _index, string _age, string _name)
    {
        index = _index;
        age = int.Parse(_age);
        name = _name;
    }
}