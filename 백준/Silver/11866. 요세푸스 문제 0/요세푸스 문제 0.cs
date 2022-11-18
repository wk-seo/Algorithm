using System.Text;
using System.Collections.Generic;

int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int qcount = 0;
Queue<int> q = new Queue<int>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < nk[0]; i++)
{
    q.Enqueue(i + 1);
}

while (q.Count > 0)
{
    qcount++;
    if (qcount == nk[1])
    {
        sb.Append(q.Dequeue().ToString()+", ");
        qcount = 0;
    }
    else q.Enqueue(q.Dequeue());
}

string answer = sb.ToString().Remove(sb.ToString().Length - 2, 2);
Console.WriteLine("<"+answer+">");