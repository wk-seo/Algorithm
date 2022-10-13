       int n = Int32.Parse(Console.ReadLine());
       Console.WriteLine(F(n));            

    int F(int n)
    {
        int result = 0;
        if (n == 0) result = 0;
        else if (n == 1) result = 1;
        else result = F(n - 1) + F(n - 2);
        return result;
    }