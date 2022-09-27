int n = int.Parse(Console.ReadLine());

int count3 = 0, count5 = 0, count = 0;
bool ok = true;

for (int i = 0; 3 * i <= n; i++)
{
    int temp1 = n - 3 * i;

    if (temp1 != 0 && temp1 % 5 != 0)
        ok = false;
    else
    {
        ok = true;
        break;
    }
}

if (ok)
{
    int t = 0;
    while ((n - (3 * t)) % 5 != 0)
    {
        t++;
    }

    count3 = t;
    count5 = (n - (3 * t)) / 5;
    count = count3 + count5;
}

else
    count = -1;


Console.WriteLine(count);