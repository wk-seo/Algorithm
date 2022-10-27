int n = int.Parse(Console.ReadLine());

int F(int n){
    int result = 0;
    if(n == 0) return result;
    else if(n == 1) return result+1;
    else{
        return F(n-1)+F(n-2);
    }
}

Console.WriteLine(F(n).ToString());