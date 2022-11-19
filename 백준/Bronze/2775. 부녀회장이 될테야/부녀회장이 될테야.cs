using System.Text;
StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int k = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    int[,] apt = new int[k + 1, n];
    for (int j = 0; j < n; j++)
    {
        apt[0, j] = j+1;
    }
    for (int j = 1; j < k + 1; j++)
    {
        for (int q = 0; q < n; q++)
        {
            for (int p = 0; p <= q; p++)
            {
                apt[j, q] += apt[j - 1, p];
            }
        }
    }
    sb.AppendLine(apt[k, n-1].ToString());
}

Console.WriteLine(sb.ToString());