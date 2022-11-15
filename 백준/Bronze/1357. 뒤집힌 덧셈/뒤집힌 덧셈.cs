string[] arr = Console.ReadLine().Split();
Console.WriteLine(Rev((Rev(arr[0])+Rev(arr[1])).ToString()));


int Rev(string x)
{
    string result = "";
    for (int i =x.Length-1; i>=0; i--)
    {
        result += x[i];
    }
    return int.Parse(result);
}