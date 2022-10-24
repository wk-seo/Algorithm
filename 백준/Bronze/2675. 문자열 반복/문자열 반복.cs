using System.Text;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int m = int.Parse(input[0]);
    string[] arr = new string[input[1].Length];

    StringBuilder sb = new StringBuilder();

    for (int j = 0; j < input[1].Length; j++)
    {
        arr[j] = input[1].Substring(j, 1);
        for (int k = 0; k < m; k++)
        {
            sb.Append(arr[j]);
        }
    }
    Console.WriteLine(sb.ToString());
}