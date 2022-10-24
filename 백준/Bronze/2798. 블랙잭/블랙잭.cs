using System.Collections.Generic;

int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> tries = new List<int>();
for (int i = 0; i < cards.Length - 2; i++)
{
    for (int j = i + 1; j < cards.Length - 1; j++)
    {
        for (int k = j + 1; k < cards.Length; k++)
        {
            if (inputs[1] - (cards[i] + cards[j] + cards[k]) >= 0) 
            {tries.Add(cards[i]+cards[j]+cards[k]);}
        }
    }
}
Console.WriteLine(tries.Max());