int l = int.Parse(Console.ReadLine());
Console.WriteLine(Hash(Console.ReadLine()));

long Hash(string s){
    long result = 0;
    long m = 1234567891;
    char[] alphabets =
    {
        'A', 'a', 'b', 'c', 'd', 'e', 'f', 'g',
        'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 
        'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };
    for (int i = 0; i < l; i++)
    {
        long r = 1;
        for (int j = 1; j<=i; j++){
            if (i == 0){
                r = 1;
                break;
            }
            r = r*31%m;
        }
        result = (result+ Array.IndexOf(alphabets, s[i]) * r) % m;
   }
    return result;
}