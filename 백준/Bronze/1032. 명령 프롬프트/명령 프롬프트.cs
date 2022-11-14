using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
string[] fileName = new string[n];
for (int i = 0; i < n; i++)
{
    fileName[i] = Console.ReadLine();
}
for (int j = 0; j < fileName[0].Length; j++)
{
    bool isSame = true;
    char s = fileName[0][j];
    for (int k = 1; k < n; k++)
    {
        if (fileName[k][j] != fileName[0][j])
        {
            isSame = false;
            break;
        }
        else
        {
            isSame = true;
        }
    }

    if (isSame)
        sb.Append(fileName[0][j]);
    else
        sb.Append('?');
}
Console.WriteLine(sb.ToString());