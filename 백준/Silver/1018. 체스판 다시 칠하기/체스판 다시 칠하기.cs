using System.Collections.Generic;


// [1] Input
 
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputs[0];
int m = inputs[1];

char[,] boards = new char[n, m];

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        boards[i, j] = s[j];
    }
}

// [2] Process

List<int> counts = new List<int>();

for (int i = 0; i <= n - 8; i++)
{
    for (int j = 0; j <= m - 8; j++)
    {
        int count = 0;
        for (int p = i; p < i + 8; p++)
        {
            for (int q = j; q < j + 8; q++)
            {
                if ((p + q) % 2 == 0 && boards[i, j] != boards[p, q])
                    count++;
                else if ((p + q) % 2 != 0 && boards[i, j] == boards[p, q])
                    count++;
            }
        }
        counts.Add(count);
        counts.Add(64 - count);
    }
}

// [3] Output
Console.WriteLine(counts.Min());