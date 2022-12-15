// [1] Input
int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nk[0];
int k = nk[1];

int[] values = new int[n];

// 동전 개수
int coinCount = 0;

for (int i = 0; i < n; i++)
{
    values[i] = int.Parse(Console.ReadLine());
}

// [2] Process 

// values 내림차순 정렬
Array.Sort(values);
Array.Reverse(values);

int index = 0;

while (k != 0)
{
    if (values[index] > k)
    {
        index++;
    }
    else
    {
        k -= values[index];
        coinCount++;                
    }
}

// [3] Output
Console.WriteLine(coinCount);