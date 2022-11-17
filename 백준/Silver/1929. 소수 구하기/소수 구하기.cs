using System.Text;

int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
StringBuilder sb = new StringBuilder();
for (int i = nums[0]; i <= nums[1]; i++)
{
    if(isPrime(i)) sb.AppendLine(i.ToString());
}
Console.WriteLine(sb.ToString());

//소수 = 약수가 자기 자신과 1만 있는 수
bool isPrime(int n)
{
    bool judge = true;
    if (n == 1) return false;
    for(int i = 2; i*i<=n; i++)
    {
        if(n%i==0){
            judge = false;
            break;
        }
    }
    return judge;
}