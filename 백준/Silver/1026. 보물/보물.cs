using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
int[] arrA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arrB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> listB = arrB.ToList();
int result = 0;
Array.Sort(arrA);
for (int i = 0; i < n; i++)
{
    result += arrA[i] * listB.Max();
    listB.Remove(listB.Max());
}
Console.WriteLine(result);