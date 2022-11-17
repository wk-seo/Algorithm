int n = int.Parse(Console.ReadLine());
int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (IsPrime(nums[i])) count++;
}

Console.WriteLine(count);
bool IsPrime(int n)
{
    bool judge = true;
    if (n == 1) return false;
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            judge = false;
            break;
        }
    }
    return judge;
}