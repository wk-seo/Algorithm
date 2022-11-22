int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arr = new int[ab[1]];
int result = 0;
int start = 1;
int count = 0;

for (int i = 0; i <ab[1]; i++)
{
    arr[i] = start;
    if (i+1 >= ab[0])
        result += arr[i];
    count++;
    if (count == start)
    {
        count = 0;
        start++;
    }
}
Console.WriteLine(result);