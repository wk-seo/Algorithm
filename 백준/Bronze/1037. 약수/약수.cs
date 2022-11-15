int n = int.Parse(Console.ReadLine());
int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(temp);
Console.WriteLine(temp[0]*temp[temp.Length-1]);