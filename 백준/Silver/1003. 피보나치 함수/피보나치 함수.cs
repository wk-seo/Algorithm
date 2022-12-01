using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int[,] count = new int[n+1, 2];
    for (int j = 0; j <= n; j++)
    {
        if (j == 0)
        {
            count[j, 0] = 1;
            count[j, 1] = 0;
        }
        else if (j == 1)
        {
            count[j, 0] = 0;
            count[j, 1] = 1;
        }
        else
        {
            count[j, 0] = count[j - 1, 0] + count[j - 2, 0];
            count[j, 1] = count[j - 1, 1] + count[j - 2, 1];
        }
    }
    sb.AppendLine(count[n,0] + " " + count[n,1]);
}
Console.WriteLine(sb.ToString());