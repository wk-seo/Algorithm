using System.Text;

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int value = n * n;
int[,] dal = new int[n, n];
int x = 0;
int y = 0;
int time = 0;
int limit = n;
while (value > 0)
{
    x = time;
    for (int i = y; i < limit; i++)
    {
        dal[i, x] = value--;
    }//rowNum 0~6, colNum0

    y = limit - 1; //y=6
    for (int i = x + 1; i <= y; i++)
    {
        dal[y, i] = value--;
    }//rowNum 6, colNum 1~6

    x = limit - 1; //x=6
    for (int i = y-1; i>=time; i--)
    {
        dal[i, x] = value--;
    }//rowNum 5~0, colNum 6 

    y = time; //y=0
    for (int i=x-1; i>time; i--)
    {
        dal[y, i] = value--;
    }//rowNum 0, colNum 5~1
    time++; //time = 1
    limit--; //limit = 6
    y = time; //y = 1;
}

StringBuilder sb = new StringBuilder();
int rx = 0, ry = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sb.Append(dal[i, j]+" ");
        if (dal[i, j] == m)
        {
            rx = i+1;
            ry = j+1;
        }
    }
    sb.AppendLine();
}
Console.Write(sb.ToString());
Console.WriteLine(rx+" "+ry);