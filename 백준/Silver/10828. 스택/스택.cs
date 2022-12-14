using System.Collections.Generic;
using System.Text;

StringBuilder sb = new StringBuilder();

List<int> stack = new List<int>();
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++){
    string[] temp = Console.ReadLine().Split();
    if(temp.Length == 2){
        stack.Add(int.Parse(temp[1]));
    }
    else{
        switch(temp[0]){
            case "pop":
                if(stack.Count==0)
                    sb.AppendLine("-1");
                else{
                    sb.AppendLine(stack[stack.Count-1].ToString());
                    stack.RemoveAt(stack.Count-1);
                }
                break;
            case "size":
                sb.AppendLine(stack.Count.ToString());
                break;
            case "empty":
                sb.AppendLine(stack.Count==0?"1":"0");
                break;
            case "top":
                sb.AppendLine(stack.Count==0?"-1":stack[stack.Count-1].ToString());
                break;
        }
    }
}

Console.WriteLine(sb.ToString());