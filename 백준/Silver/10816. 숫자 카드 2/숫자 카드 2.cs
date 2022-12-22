using System.Text;
using System.Collections.Generic;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
int[] ns = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int m = int.Parse(Console.ReadLine());
int[] compares = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    if (!dict.TryAdd(ns[i], 1))
        dict[ns[i]]++;
}

Array.Sort(ns);

for (int i = 0; i < m; i++)
{
    sb.Append((BinarySearch(0, n-1, compares[i]) ? dict[compares[i]] : "0")+" ");
}

Console.WriteLine(sb.ToString().TrimEnd());

bool BinarySearch(int start, int end, int num)
{
    bool answer = false;

    while (start <= end)
    {
        int mid = (start + end) / 2;

        if (ns[mid] == num)
        {
            answer = true;
            return answer;
        }

        if (ns[mid] > num)
        {
            end = mid - 1;
        }

        else // ns[mid] < num
        {
            start = mid + 1;
        }

    }

    return answer;
}
