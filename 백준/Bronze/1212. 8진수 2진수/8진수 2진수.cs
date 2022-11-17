using System.Text;

StringBuilder sb = new StringBuilder();
string s = Console.ReadLine();
int l = s.Length;
if (s == "0" && l == 1)
    Console.WriteLine(0);
else
{
    sb.Append(Last(s[0]));
    for (int i = 1; i < l; i++)
    {
        sb.Append(Convert(s[i]));
    }
    Console.WriteLine(sb.ToString());
}

string Convert(char a)
{
    string result = "";
    switch (a)
    {
        case '0':
            result = "000";
            break;
        case '1':
            result = "001";
            break;
        case '2':
            result = "010";
            break;
        case '3':
            result = "011";
            break;
        case '4':
            result = "100";
            break;
        case '5':
            result = "101";
            break;
        case '6':
            result = "110";
            break;
        case '7':
            result = "111";
            break;
    }
    return result;
}

string Last(char a)
{
    string result = "";
    switch (a)
    {
        case '1': result = "1";
            break;
        case '2': result = "10";
            break;
        case '3': result = "11";
            break;
        case '4': result = "100";
            break;
        case '5': result = "101";
            break;
        case '6': result = "110";
            break;
        case '7': result = "111";
            break;
    }
    return result;
}