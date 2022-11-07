using System.Collections.Generic;

int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputs[0]; int m = inputs[1];
int[] pkgPrice = new int[m];
int[] echPrice = new int[m];
List<int> p = new List<int>();
int min = 0;
int may = 0;

for (int i = 0; i < m; i++)
{
    int[] prices = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    pkgPrice[i] = prices[0];
    echPrice[i] = prices[1];
}

min += n / 6 * pkgPrice.Min();
min += n % 6 * echPrice.Min();
p.Add(min);
may = (n / 6 + 1) * pkgPrice.Min();
p.Add(may);
p.Add(n*echPrice.Min());


Console.WriteLine(p.Min());
