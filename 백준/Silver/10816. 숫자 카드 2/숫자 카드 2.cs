using System.Collections.Generic;
using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
int[] sangCard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Dictionary<int, int> sangCards = new Dictionary<int, int>();

for(int i = 0; i < n; i++){

    if(!sangCards.TryAdd(sangCard[i], 1))
        sangCards[sangCard[i]]++;
}

int m = int.Parse(Console.ReadLine());
int[] compareCard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] trimedSangCard = sangCards.Keys.ToArray();
Array.Sort(trimedSangCard);

for (int i = 0; i < m; i++)
{
    if (BinarySearch(compareCard[i], trimedSangCard, 0, trimedSangCard.Length - 1))
        sb.Append(sangCards[compareCard[i]] + " ");
    else
        sb.Append("0 ");
}

Console.WriteLine(sb.ToString().TrimEnd());

bool BinarySearch(int num, int[] list, int start, int end)
{
    bool isThere = false;
    while (start <= end)
    {
        int mid = (start + end) / 2;
        if (list[mid] == num)
        {
            isThere = true;
            return isThere;
        }

        else if (list[mid] > num)
            end = mid - 1;

        else start = mid + 1;
    }
    return isThere;
}
