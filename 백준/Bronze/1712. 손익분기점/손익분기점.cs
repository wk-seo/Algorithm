long[] inputs = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
if (inputs[2] <= inputs[1])
{
    Console.WriteLine(-1);
    return;
}

Console.WriteLine(inputs[0]/(inputs[2]-inputs[1]) +1);