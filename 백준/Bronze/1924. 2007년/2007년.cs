int[] dates = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int i = 0;
string[] week = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
int[] dayNum = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int date = 0;
if (dates[0] == 1) date = dates[1];
else
{
    for (int j = 0; j < dates[0]-1; j++)
    {
        date += dayNum[j];
    }
    date += dates[1];
}

Console.WriteLine(week[date%7]);