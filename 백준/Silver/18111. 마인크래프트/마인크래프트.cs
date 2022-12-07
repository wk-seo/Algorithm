int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputs[0]; 
int m = inputs[1]; 
long[,] height = new long[n,m];
long inven = inputs[2]; 

long max = 0;
long min = 256;

for (int i = 0; i < n; i++)
{
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
    {
        height[i, j] = temp[j];
        if (height[i, j] > max)
            max = height[i, j];

        if (height[i, j] < min)
            min = height[i, j];
    }
}

long time = 0;
long minTime = int.MaxValue;
long ansHeight = 256;

for (long q = max; q>=min; q--)
{
    inven = inputs[2];
    time = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            long diff = q - height[i, j];
            inven -= diff;

            if (diff < 0)
                time -= diff * 2;

            else if (diff > 0)
                time += diff;
        }
    }

    if (inven >= 0 && time < minTime)
    {
        minTime = time;
        ansHeight = q;
    }
}

Console.WriteLine(minTime+ " "+ansHeight);