using System.Collections.Generic;
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int max = 0;
    List<int> votes = new List<int>();
    int sum = 0;
    string status = "";
    for (int j = 0; j < n; j++)
    {
        votes.Add(int.Parse(Console.ReadLine()));
        sum += votes[j];
    }

    max = votes.Max();

    if (max <= sum / 2)
        status = "minority winner";
   
    else
        status = "majority winner";

    status += (" " + (votes.IndexOf(max)+1));

    votes.Remove(votes.Max());
    if (votes.Contains(max))
        Console.WriteLine("no winner");
    else
        Console.WriteLine(status);
}