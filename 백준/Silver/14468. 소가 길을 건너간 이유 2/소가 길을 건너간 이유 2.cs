string s = Console.ReadLine();
int[,] cow = new int[26,2];
for (int i = 0; i < s.Length; i++)
{
    int now = s[i] - 'A';
    if (cow[now, 0] == 0) cow[now, 0] = i + 1;
    else cow[now, 1] = i + 1;
}

int ans = 0;
int n = 26;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int s1 = cow[i, 0];
        int e1 = cow[i, 1];
        int s2 = cow[j, 0];
        int e2 = cow[j, 1];
        if (s1 < s2 && s2 < e1 && e1 < e2) ans++;
    }
}
Console.WriteLine(ans);