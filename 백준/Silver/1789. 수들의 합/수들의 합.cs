long s = long.Parse(Console.ReadLine());
//s=n개의 자연수의 합, 자연수는 각자 다르다.
long result = 0;
long start = 0;
while (result <= s)
{
    start++;
    result += start;
    if (result > s) break;
}
Console.WriteLine(start-1);