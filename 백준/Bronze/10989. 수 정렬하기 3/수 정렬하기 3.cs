using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
using var printer = new System.IO.StreamWriter(Console.OpenStandardOutput());

int[] nums = new int[10001];
int n = int.Parse(reader.ReadLine());
for (int i = 0; i < n; i++)
{
    nums[int.Parse(reader.ReadLine())]++;
}

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] != 0)
    {
        for (int j = 0; j < nums[i]; j++)
        {
            printer.WriteLine(i);
        }
    }
}