int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputs[0]; //책의 개수
int m = inputs[1]; //박스에 넣을 수 있는 최대 무게
int count = 0;

if (n == 0)
{
    Console.WriteLine(count);
}
else
{

    int[] weight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    List<int> sum = Enumerable.Repeat(0, n).ToList();
    int j = 0;

    for (int i = 0; i < n; i++)
    {
        if (sum[j] + weight[i] <= m)
        {
            sum[j] += weight[i];
        }
        else
        {
            j++;
            sum[j] += weight[i];
        }
    }

    for (int k = 0; k < sum.Count; k++)
    {
        if (sum[k] > 0) count++;
    }

    Console.WriteLine(count);
}