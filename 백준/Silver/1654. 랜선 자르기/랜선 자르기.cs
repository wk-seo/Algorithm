using System.Numerics;

BigInteger[] kn = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
BigInteger k = kn[0], n = kn[1];
BigInteger[] originLan = new BigInteger[(int)k];
BigInteger count;

for (int i = 0; i < k; i++)
{
    originLan[i] = int.Parse(Console.ReadLine());
}

BigInteger start = 1, mid, end = originLan.Max();

while (start <= end)
{
    count = 0;
    mid = (start + end) / 2;
    for (int i = 0; i < originLan.Length; i++)
    {
        count += originLan[i] / mid;
    }

    if (count < n)
    {
        end = mid - 1;

    }
    else
    {
        start = mid + 1;
    }
}

Console.WriteLine(end);