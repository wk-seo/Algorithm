using System.Collections.Generic;

int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = inputs[0];
int y = inputs[1];
int w = inputs[2];
int h = inputs[3];

List<int> distance = new List<int>();
distance.Add(x-0);
distance.Add(w-x);
distance.Add(y-0);
distance.Add(h-y);

Console.WriteLine(distance.Min());