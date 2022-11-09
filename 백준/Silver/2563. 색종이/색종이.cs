int n = int.Parse(Console.ReadLine());
int[,] pos = new int[n, 2];
int paint = 0;
bool[,] dodo = new bool[100, 100];

for (int i = 0; i < n; i++)
{
    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = temp[0]; j < temp[0] + 10; j++)
    {
        for (int r = temp[1]; r < temp[1] + 10; r++)
        {
            dodo[j, r] = true;
        }
    }
}

Console.WriteLine(dodo.Cast<bool>().Where(a => a == true).Count());