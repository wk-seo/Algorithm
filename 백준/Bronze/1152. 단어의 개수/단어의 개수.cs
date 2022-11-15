string s = Console.ReadLine();
int count = 0;
if (s != " ")
{
    s = s.TrimEnd().TrimStart();
    if (s.Length == 1)
    {
        count = 1;
    }
    else
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                count++;
        }
        ++count;
    }
}

Console.WriteLine(count);