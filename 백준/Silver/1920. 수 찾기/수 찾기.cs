using System.Text;

int n = int.Parse(Console.ReadLine());
int[] arrA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
StringBuilder sb = new StringBuilder();

Array.Sort(arrA);
for (int i = 0; i < m; i++)
{
    int temp = arr[i];
    sb.AppendLine(BinarySearch(0, n - 1, arr[i]).ToString());
}

Console.WriteLine(sb.ToString());

int BinarySearch(int start, int end, int num)
{
    int mid = (start + end) / 2;
    if (arrA[mid] == num) return 1;
    else if (num < arrA[start] || num > arrA[end]) return 0;
    else
    {
        if (arrA[mid] > num) return BinarySearch(start, mid, num);
        else return BinarySearch(mid + 1, end, num);
    }
}