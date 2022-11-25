long[] nm = Array.ConvertAll(Console.ReadLine().Split(), long.Parse); // Inputs 나무의 수, 가져갈 나무 길이 합
long[] height = Array.ConvertAll(Console.ReadLine().Split(), long.Parse); // Inputs 나무의 길이
long total; // 절단한 나무 길이의 합
Array.Sort(height);

long start = 0;
long mid; //이분탐색 가운데 index
long end = height.Max();

while (start <= end)
{
    total = 0;
    mid = (start + end) / 2;
    for (int i = 0; i < height.Length; i++)
    {
        if (height[i] > mid)
            total += height[i] - mid;
    }

    if (total < nm[1])
        end = mid - 1;
    else
    {
        start = mid + 1;
    }
}

Console.WriteLine(end);