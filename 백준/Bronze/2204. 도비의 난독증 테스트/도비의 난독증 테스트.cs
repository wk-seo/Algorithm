using System.Collections.Generic;
using System.Linq;

List<string> input = new List<string>();
while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0 || n==1) break;
    for (int i = 0; i < n; i++)
    {
        input.Add(Console.ReadLine());
    }
    input.Sort((x, y) => x.ToUpper().CompareTo(y.ToUpper()));
    Console.WriteLine(input[0]);
    input.Clear();
}