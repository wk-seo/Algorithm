using System.Collections.Generic;
using System.Text;

List<int> origin = new List<int>();
List<int> list = new List<int>();
Stack<int> stack = new Stack<int>();
StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int idx = 0;
int start = 1;
bool check = true;
for (int i = 1; i <= n; i++)
{
    origin.Add(int.Parse(Console.ReadLine()));
}

//for (int i =1; i <= n; i++)
while(idx<origin.Count)
{
    if (stack.Count != 0 && stack.Peek() == origin[idx])
    {
        list.Add(stack.Pop());
        if (list[idx] != origin[idx])
        {
            check = false;
            break;
        }
        sb.AppendLine("-");
        idx++;
    }
    else
    {
        if (start > origin.Count)
        {
            check = false;
            break;
        }
        stack.Push(start);
        sb.AppendLine("+");
        start++;
    }
}
Console.WriteLine(check?sb.ToString():"NO");