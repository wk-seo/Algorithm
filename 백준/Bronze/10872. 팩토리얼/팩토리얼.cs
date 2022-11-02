int n = int.Parse(Console.ReadLine());
int answer = n;
if (n == 0) answer = 1;
else
{
    while (n - 1 > 1)
    {
        if (n - 1 == 1) break;
        answer *= (n - 1);
        n--;
    }
}

Console.WriteLine(answer);