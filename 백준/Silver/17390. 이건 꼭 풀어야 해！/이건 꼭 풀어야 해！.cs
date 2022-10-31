using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = inputs[0];
int q = inputs[1];

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(arr);
int[] sum = new int[n+1];
sum[0] = 0;
for (int i = 1; i < n+1; i++)
{
    sum[i] = sum[i - 1] + arr[i-1];
}

for (int i = 0; i < q; i++)
{
    int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    sb.AppendLine((sum[nums[1]] - sum[nums[0] - 1]).ToString());
}

Console.WriteLine(sb.ToString());