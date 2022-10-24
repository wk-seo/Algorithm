using System.Collections.Generic;
using System.Text;

public class MainApp{
    
    static List<string> sstack = new List<string>();
    static StringBuilder sb = new StringBuilder();
    
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            sb.Clear();
            string[] str = Console.ReadLine().Split();
            
            switch (str[0])
            {
                case "push":
                    push(str[1]);
                    break;
                case "pop":
                    pop();
                    break;
                case "size":
                    size();
                    break;
                case "empty":
                    empty();
                    break;
                case "top":
                    top();
                    break;
            }
        }
    }
    
    public static void push(string x)
    {
        sstack.Add(x);
    }

    public static void pop()
    {
        sb.Append(sstack.Count == 0 ? "-1" : sstack[sstack.Count - 1]);
        Console.WriteLine(sb);
        if(sstack.Count!=0) 
            sstack.RemoveAt(sstack.Count - 1);
    }

    public static void size()
    {
        sb.Append(sstack.Count);
        Console.WriteLine(sb);
    }

    public static void empty()
    {
        sb.Append(sstack.Count == 0 ? "1" : "0");
        Console.WriteLine(sb);
    }

    public static void top()
    {
        sb.Append(sstack.Count == 0 ? "-1" : sstack[sstack.Count - 1]);
        Console.WriteLine(sb);
    }
    
    
    
}