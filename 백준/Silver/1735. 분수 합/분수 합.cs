long[] input1 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long[] input2 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

long bae = input1[1] * input2[1] / GetGcd(input1[1], input2[1]);

long[] output = { input1[0] * bae / input1[1] + input2[0] * bae / input2[1], bae};
long temp2 = GetGcd(output[0], output[1]);
Console.WriteLine(output[0] / temp2 + " " + output[1] / temp2);

//최대공약수
long GetGcd(long a, long b)
{
    while (b > 0)
    {
        long tmp = a;
        a = b;
        b = tmp % b;
    }

    return a;
}