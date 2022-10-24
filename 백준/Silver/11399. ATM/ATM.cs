int n = int.Parse(Console.ReadLine());

int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(inputs);
int answer = inputs[0]; 
for (int i = 1; i < n; i++)
{
    inputs[i] += inputs[i - 1];
    answer += inputs[i];
}
Console.WriteLine(answer);