int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long n = 1;
long m = 1;
for (int i = nm[0]; i >nm[0]- nm[1]; i--)
{
    n *= i;
}

for (int i = nm[1]; i >= 1; i--)
{
    m *= i;
}
Console.WriteLine(n/m);