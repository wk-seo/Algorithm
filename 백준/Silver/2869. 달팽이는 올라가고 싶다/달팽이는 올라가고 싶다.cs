int[] n = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
int a = n[0], b = n[1], v = n[2];
int c = 0, d = 0;

d = (v - b - 1) / (a - b) + 1;
Console.WriteLine(d);