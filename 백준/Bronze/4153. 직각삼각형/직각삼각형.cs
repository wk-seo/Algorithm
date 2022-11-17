using System.Text;

string s="";
StringBuilder sb = new StringBuilder();
while (s != "0 0 0")
{
    s = Console.ReadLine();
    if (s == "0 0 0") break;
    int[] arr = Array.ConvertAll(s.Split(), int.Parse);
    Array.Sort(arr);
    sb.AppendLine(arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2] ? "right" : "wrong");
}

Console.WriteLine(sb.ToString());