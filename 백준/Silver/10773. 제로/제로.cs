using System.Collections.Generic;

int k = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < k; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
    if (list[i] == 0)
    {
        for (int j = list.Count - 1; j >= 0; j--)
        {
            if (list[j] != 0)
            {
                list[j] = 0;
                break;
            }
        }
    }             
}
Console.WriteLine(list.Sum());