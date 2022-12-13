List<int> list = new List<int>();
int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
    {
        list.RemoveAt(list.Count-1);
    }
    else
    {
        list.Add(x);
    }
}
Console.WriteLine(list.Sum());