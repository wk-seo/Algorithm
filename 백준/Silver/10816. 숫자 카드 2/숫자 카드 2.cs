using System.Collections.Generic;
using System.Text;

Dictionary<int, int> dict = new Dictionary<int, int>();
StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
int[] sc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < sc.Length; i++)
{
    if (!dict.TryAdd(sc[i], 1))
        dict[sc[i]]++;
}

int m = int.Parse(Console.ReadLine());
int[] compare = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(sc);

for (int i = 0; i < compare.Length; i++)
{
    sb.Append((BinarySearch(0, sc.Length - 1, compare[i]) ? dict[compare[i]].ToString() : "0")+" ");
}

Console.WriteLine(sb.ToString().TrimEnd());

bool BinarySearch(int start, int end, int num)
{
    bool check = false;

    while (start <= end)
    {
        int mid = (start + end) / 2;

        if (sc[mid] == num)
        {
            check = true;
            return check;
        }

        if (sc[mid] < num)
        {
            start = mid + 1;
        }

        else // sc[mid] > num
        {
            end = mid - 1;
        }
    }

    return check;
}
