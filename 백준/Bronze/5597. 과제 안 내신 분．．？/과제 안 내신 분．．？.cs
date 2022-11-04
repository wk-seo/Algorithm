int[] studentNums = new int[30];
int[] submitNums = new int[28];
for (int i = 0; i < 30; i++)
{
    studentNums[i] = i + 1;
}

for (int i = 0; i < 28; i++)
{
    submitNums[i] = int.Parse(Console.ReadLine());
    if (studentNums.Contains(submitNums[i]))
    {
        studentNums[Array.IndexOf(studentNums, submitNums[i])] = 100;
    }
}

Array.Sort(studentNums);
Console.WriteLine(studentNums[0]);
Console.WriteLine(studentNums[1]);