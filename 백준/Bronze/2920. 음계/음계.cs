int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool isAsc = false;
bool isDes = false;
for (int i = 0; i < arr.Length-1; i++)
{
    if (arr[i] < arr[i + 1])
        isAsc = true;
    else if(arr[i]>arr[i+1])
        isDes = true;
}
if((isAsc&&isDes)||(!isAsc&&!isDes)) Console.WriteLine("mixed");
else Console.WriteLine(isAsc?"ascending":"descending");