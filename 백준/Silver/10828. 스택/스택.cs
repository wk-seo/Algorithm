using System.Collections.Generic;
using System.Text;

StringBuilder sb = new StringBuilder();

// Push, Pop, Count, Peek
Stack<int> stack = new Stack<int>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine().Split();

    if(inputs.Length>1)
        stack.Push(int.Parse(inputs[1]));
    else
    {
        switch (inputs[0])
        {
            case "pop":
                sb.AppendLine(stack.Count>0 ? stack.Pop().ToString() : "-1");
                break;
            case "size":
                sb.AppendLine(stack.Count.ToString());
                break;
            case "empty":
                sb.AppendLine(stack.Count == 0 ? "1" : "0");
                break;
            case "top":
                sb.AppendLine(stack.Count > 0 ? stack.Peek().ToString() : "-1");
                break;
        }//switch(input[0])
    }
}//for

Console.WriteLine(sb.ToString());