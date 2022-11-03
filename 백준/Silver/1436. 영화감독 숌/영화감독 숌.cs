using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
int jong = 666;
List<int> jongmals = new List<int>();
int i = 1;
int count;
while(i>jongmals.Count)
{
    count = 0;

    for (int j = 0; j < jong.ToString().Length; j++)
    {
        if (jong.ToString()[j] == '6')
        {
            count++;
            if (count == 3) break;
        }
        else
        {
            count = 0; 
        }
    }

    if (count == 3)
    {
        jongmals.Add(jong);
        if (jongmals.Count==n) break;
        i++;
    }
    jong++;
}

Console.WriteLine(jong);