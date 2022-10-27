using System.Collections.Generic;
using System.Text;

StringBuilder counts = new StringBuilder();
int n = Int32.Parse(Console.ReadLine());
string[] inputs = Console.ReadLine().Split();

int m = int.Parse(Console.ReadLine());
string[] ms = Console.ReadLine().Split();

Dictionary<string, int> cards = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    if(!cards.ContainsKey(inputs[i]))
        cards.Add(inputs[i], 1);
    else
        cards[inputs[i]]++;
}

for (int j = 0; j < m; j++)
{
    if (!cards.ContainsKey(ms[j]))
    {
        counts.Append("0 ");
    }
    else counts.Append(cards[ms[j]]+" ");
}

Console.WriteLine(counts);