int n = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= n; i++)
{
    if (i < 100)
        count++;
    else
    {
        if (isHan(i))
            count++;
    }
}

Console.WriteLine(count);

bool isHan(int n) //23
{
    bool answer = true;
    string s = n.ToString();
    int cha = 0;
    for (int i = 0; i<s.Length-1; i++)
    {
        if (i == 0)
            cha = s[1] - s[0];
        else
        {
            if (s[i + 1] - s[i] != cha)
            {
                answer = false;
                break;
            }
        }
    }
    return answer;
}