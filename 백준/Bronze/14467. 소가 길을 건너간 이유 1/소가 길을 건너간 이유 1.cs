using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
int[] counts = new int[11];
Dictionary<int, int> cow = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if(!cow.TryAdd(temp[0], temp[1]))
    {
        if (cow[temp[0]] != temp[1])
        {
            cow[temp[0]] = temp[1];
            counts[temp[0]]++;
        }
    }
}
Console.WriteLine(counts.Sum());