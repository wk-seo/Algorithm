int 가게수 = int.Parse(Console.ReadLine());
int 마신횟수 = 0;
int[] 가게들 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] 영학규칙 = { 0, 1, 2 };
int 영학순서 = 0;
for (int i = 0; i < 가게수; i++)
{
    if (가게들[i] == 영학규칙[영학순서])
    {
        마신횟수++;
        영학순서++;
        if (영학순서 > 2)
            영학순서 %= 3;
    }
}

Console.WriteLine(마신횟수);