long a = long.Parse(Console.ReadLine());
long answer = 1;
long temp = 1;
if (a == 1)
{
    Console.WriteLine(answer);
    return;
}

while(answer<a)
{
    if (answer >= a) break;
    answer += 6 * temp;
    temp++;
}

Console.WriteLine(temp);