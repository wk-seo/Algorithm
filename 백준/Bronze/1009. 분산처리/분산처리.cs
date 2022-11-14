using System.Collections.Generic;

int t = int.Parse(Console.ReadLine());
int answer = 0;
List<int> numerics = new List<int>();

for (int i = 0; i < t; i++)
{
    numerics.Clear();
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputs[0];
    int namuji = a % 10;
    if (a == 0) answer = 1;
    else if (namuji == 0 && a > 0)
    {
        answer = 10;
    }
    else
    {
        while (true)
        {
            numerics.Add(namuji);
            namuji = namuji * a % 10;
            if (numerics.Contains(namuji))
            {
                break;
            }
        }

        if (numerics.Count == 1)
        {
            answer = numerics[0];
        }

        else if (inputs[1] % numerics.Count == 0)
        {
            answer = numerics[numerics.Count - 1];

        }

        else
        {
            answer = numerics[inputs[1] % numerics.Count - 1];
        }
    }

    Console.WriteLine(answer);
}