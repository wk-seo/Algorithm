int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] moneys = new int[inputs[0]];
int cnt = 0;
int j = moneys.Length-1;
for (int i = 0; i < inputs[0]; i++)
{
    moneys[i] = int.Parse(Console.ReadLine());
}

while(inputs[1] != 0)
{
    if (inputs[1] == 0) break;
    if (moneys[j] > inputs[1]) j--;
    else//(moneys[j] <= inputs[1]) 
    {
        inputs[1] -= moneys[j];
        cnt++;
    }
}
Console.WriteLine(cnt);