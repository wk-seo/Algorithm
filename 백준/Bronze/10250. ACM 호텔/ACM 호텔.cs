using System.Text;

StringBuilder rn = new StringBuilder();
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    rn.Clear();
    int a = inputs[2]/inputs[0]+1; //i == 10, 10/6 = 1(열번호)
    int b = inputs[2] % inputs[0]; //==층수
    if(b==0) {b = inputs[0]; a-= 1;}
    rn.Append(b.ToString());
    if (a < 10) rn.Append("0");
    rn.Append(a.ToString());
    Console.WriteLine(rn);
}