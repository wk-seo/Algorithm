int n = int.Parse(Console.ReadLine());
int temp = 0;
while(n>=5){
    temp += n / 5;
    n /= 5;
}
Console.WriteLine(temp);