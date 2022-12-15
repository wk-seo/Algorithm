// [1] Input
int n = int.Parse(Console.ReadLine());
int[] p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// [2] Process
int minTime = 0;
int sumMinTime = 0;

Array.Sort(p);
for (int i = 0; i < p.Length; i++)
{
    minTime += p[i];
    sumMinTime += minTime;
}

// [3] Output
Console.WriteLine(sumMinTime);