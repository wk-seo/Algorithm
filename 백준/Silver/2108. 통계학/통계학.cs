using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
Dictionary<int, int> frequency = new Dictionary<int, int>();
List<int> check = new List<int>();
int bin = 0;

for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
    if(!frequency.TryAdd(nums[i], 1))
    {
        frequency[nums[i]]++;
    }
}


foreach (var item in frequency)
{
    if(item.Value==frequency.Max(x=>x.Value))
        check.Add(item.Key);
}
check.Sort();

bin = check.Count > 1 ? check[1] : check[0];

Array.Sort(nums);
double answer1 = Math.Round(nums.Average());

Console.WriteLine(answer1==-0?0:answer1);
Console.WriteLine(nums[nums.Length/2]);
Console.WriteLine(bin);
Console.WriteLine(nums.Max()-nums.Min());