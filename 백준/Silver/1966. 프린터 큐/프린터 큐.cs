using System.Collections.Generic;

int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int count = 0;
    int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
    for (int j = 0; j <nm[0]; j++)
    {
        q.Enqueue(new KeyValuePair<int, int>(j, temp[j]));
    }
    while (true)
    {
        int r = q.Max(x=>x.Value);
        var dq = q.Dequeue();
        if (dq.Value==r)
        {
            if (dq.Key == nm[1])
                break;
            count++;
            continue;
        }
        q.Enqueue(dq);
    }
    Console.WriteLine(count+1);
    q.Clear();
}