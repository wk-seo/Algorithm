int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;
int count = 0;
int idx = 0;
int startIdx = 0;

while (true)
{
    if (sum == nm[1])
    {
        count++;
        sum = 0;
        startIdx++;
        idx = startIdx;
    }
    else if (sum > nm[1])
    {
        sum = 0;
        startIdx++;
        idx = startIdx;
    }

    if (idx > arr.Length - 1)
        break;

    sum += arr[idx];
    idx++;
}
Console.WriteLine(count);