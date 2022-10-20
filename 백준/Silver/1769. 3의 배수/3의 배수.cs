public class MainApp{
    
    static int count = 0;
    
    public static void Main(string[] args){
        string input = Console.ReadLine();

        while (true)
        {
            input = Calc(input);
            if (input.Length == 1) break;
        }
        Console.WriteLine(count);
        if(int.Parse(input)%3 == 0) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
    
    public static string Calc(string s){
        if (s.Length == 1) return s;
        
        count++;
        int temp = 0;
        for (int i = 0; i < s.Length; i++)
        {
            temp += int.Parse(s.Substring(i, 1));
        }

        return temp.ToString();
    }
    
    
}