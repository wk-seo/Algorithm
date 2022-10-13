class MainApp
{
    static int count;
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputs = new string[n];
        for(int i = 0; i < n; i++)
        {            
           inputs[i] = Console.ReadLine();
        }
        
        for(int i = 0; i < n; i++)
        {
            count = 1;
            Console.WriteLine(isPalindrome(inputs[i])+" "+count);
        }
    }
    
    static int recursion(string s, int l, int r)
    {
        if(l >= r) return 1;
        else if(s[l] != s[r]) return 0;
        else
        {
            ++count;
            return recursion(s, l+1, r-1);
        }
    }
    
    static int isPalindrome(string s)
    {
        return recursion(s, 0, s.Length-1);
    }
    
}