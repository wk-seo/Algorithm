int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = input[0];
int M = input[1];
string[,] inputs = new string[N,M];
for (int i = 0; i < N; i++)
{
    string[] temps = new string[N];
    temps[i] = Console.ReadLine();
    for (int j = 0; j < M; j++)
    {
        inputs[i, j] = temps[i].Substring(j, 1);
    }
}

List<int> counts = new List<int>();
for (int i = 0; i <= (N - 8); i++)
{
    for (int j = 0; j <= (M - 8); j++)
    {
        int cnt1 = 0; //시작이 W일 때 바꾸는 경우의 수
        int cnt2 = 0; //시작이 B일 때 바꾸는 경우의 수

        for (int q = i; q < i + 8; q++)
        {
            for (int r = j; r < j + 8; r++)
            {
                if (q%2 ==0)//짝수번째가 W로 시작할 경우....
                {
                    if (r % 2 == 0)
                    {
                        if (inputs[q, r] == "B") cnt1++;
                    }
                    else
                    {
                        if (inputs[q, r] == "W") cnt1++;
                    }
                }

                else
                {
                    if (r % 2 == 0)
                    {
                        if (inputs[q, r] == "W") cnt1++;
                    }
                    else
                    {
                        if (inputs[q, r] == "B") cnt1++;
                    }
                }

                if (q%2 ==0)//짝수번째가 B로 시작할 경우....
                {
                    if (r % 2 == 0)
                    {
                        if (inputs[q, r] == "W") cnt2++;
                    }
                    else
                    {
                        if (inputs[q, r] == "B") cnt2++;
                    }
                }

                else
                {
                    if (r % 2 == 0)
                    {
                        if (inputs[q, r] == "B") cnt2++;
                    }
                    else
                    {
                        if (inputs[q, r] == "W") cnt2++;
                    }
                }
            }
        }
        counts.Add(cnt1);
        counts.Add(cnt2);
    }

}
Console.WriteLine(counts.Min());