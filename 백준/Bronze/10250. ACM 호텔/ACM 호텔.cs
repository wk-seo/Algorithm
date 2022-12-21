using System.Text;

StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int h = inputs[0];
    int w = inputs[1];
    int n = inputs[2];

    //h = 6, w = 12, n = 10

    int floor = 0;
    int ho = 0;

    if (n % h == 0)
    {
        floor = h;
        ho = n / h;
    }
    else
    {
        floor = n % h;
        ho = n / h + 1;
    }

    sb.AppendLine(ho < 10 ? floor + "0" + ho : floor.ToString() + ho);
}

Console.WriteLine(sb.ToString());