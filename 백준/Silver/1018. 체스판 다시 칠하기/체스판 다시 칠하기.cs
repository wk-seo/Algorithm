using System.Collections.Generic;

int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nm[0]; // 행 크기
int m = nm[1]; // 열 크기

List<int> counts = new List<int>();

string[,] board = new string[n, m];

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        board[i, j] = s.Substring(j, 1);
    }
}

for (int i = 0; i <= n - 8; i++)
{
    for (int j = 0; j <= m - 8; j++)
    {
        int count = 0;
        for (int p = i; p < i + 8; p++)
        {
            for (int q = j; q < j + 8; q++)
            {
                if ((p + q) % 2 == 0 && (board[p, q] != board[i, j]))
                    count++;
                else if ((p + q) % 2 == 1 && (board[p, q] == board[i, j]))
                    count++;
            }
        }
        counts.Add(count);
        counts.Add(64-count);
    }   
}
Console.WriteLine(counts.Min());
