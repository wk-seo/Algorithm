int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = input[0];
int y = input[1];
int[] DP = new int[y+1]; 

DP[0] = h;
for (int i = 1; i <= y; i++)
{
    DP[i] = (int)(DP[i - 1] * 1.05);
    if (i >= 3)
    {
        DP[i] = Math.Max(DP[i], (int)(DP[i-3]*1.2));
    }
    if (i >= 5)
    {
        DP[i] = Math.Max(DP[i], (int)(DP[i - 5] * 1.35));
    }
}

Console.WriteLine(DP[y]);