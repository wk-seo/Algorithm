using System.Collections.Generic;

string s = "";
while(s!=".")//입력 반복문
{
    List<char> list = new List<char>();
    s = Console.ReadLine();
    if (s == ".") break;
    int bigC = 0;
    int smallC = 0;
    bool check = true;

    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i])
        {
            case '(':
                smallC += 1;
                list.Add(s[i]);
                break;
            case '[':
                bigC += 1;
                list.Add(s[i]);
                break;
            case ')':
                if (smallC != 0 && list[list.Count - 1] == '(')
                {
                    smallC -= 1;
                    list.RemoveAt(list.Count - 1);
                }
                else
                    check = false;
                break;
            case ']':
                if (bigC != 0 && list[list.Count - 1] == '[')
                {
                    bigC -= 1;
                    list.RemoveAt(list.Count - 1);
                }
                else
                    check = false;
                break;
        }
        if (!check) break;
    }
    Console.WriteLine(check&&smallC==0&&bigC==0 ? "yes" : "no");
    list.Clear();
}