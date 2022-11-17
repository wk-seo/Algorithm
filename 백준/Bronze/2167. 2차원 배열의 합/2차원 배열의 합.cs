using System.Text;
int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[,] arr = new int[nm[0], nm[1]];
for (int i = 0; i < nm[0]; i++)
{
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < nm[1]; j++)
    {
        arr[i, j] = temp[j];
    }
}

int k = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 0; i < k; i++)
{
    int sum = 0;
    int[] temps = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = temps[0]-1; j <= temps[2]-1; j++)
    {
        for (int q = temps[1]-1; q <= temps[3]-1; q++)
        {
            sum += arr[j, q];
        }
    }
    sb.AppendLine(sum.ToString());
}
Console.WriteLine(sb.ToString());