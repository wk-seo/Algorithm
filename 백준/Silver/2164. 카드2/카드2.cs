int n = int.Parse(Console.ReadLine());
Queue<int> q = new Queue<int>();

for (int i = 1; i <= n; i++)
{
    q.Enqueue(i);
}

while (q.Count != 1)
{
    int a = q.Dequeue();
    int b = q.Dequeue();
    q.Enqueue(b);
}

int reslut = q.Dequeue();

Console.WriteLine(reslut);