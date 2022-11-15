int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = nums[0];
    int b = nums[1];
    //두 수의 최소 공배수 먼저 구하기
    int remains = nums[1];
    while (remains > 0)
    {
        remains = b%a;
        if (remains == 0)
            break;
        b = a;
        a = remains;
    }
    //Console.WriteLine("최대공약수: "+a);
    Console.WriteLine(nums[0]*nums[1]/a);
}