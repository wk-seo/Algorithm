int n = int.Parse(Console.ReadLine());
Console.WriteLine(Facto(n));

int Facto(int n){
     if (n == 0 || n==1) return 1;
     return n * Facto(n - 1);
 }