int n = int.Parse(Console.ReadLine());
int[] xs = new int[n];
int[] ys = new int[n];
int[] rn = Enumerable.Repeat<int>(1, n).ToArray<int>();
for (int i = 0; i < n; i++)
{
    int[] temp = new int[2];
    temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    xs[i] = temp[0];
    ys[i] = temp[1];
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (xs[i] < xs[j] && ys[i] < ys[j])
        {
            rn[i]++;
        }
    }
}

foreach (int r in rn)
{
    Console.Write(r+" ");
}