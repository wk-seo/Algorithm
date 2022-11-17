int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string s = Console.ReadLine();
    int count = 0;
    string answer = "";
    if (s[0] == ')'|| s[s.Length-1]=='(') answer = "NO";
    else
    {
        for (int j = 0; j < s.Length; j++)
        {
            if (count == 0 && s[j] == ')') answer = "NO";
            else
            {
                if (s[j] == ')')
                    count -= 1;
                else
                    count += 1;
            }
        }
    }

    Console.WriteLine(count == 0 &&answer=="" ? "YES" : "NO");
}