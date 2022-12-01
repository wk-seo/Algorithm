using System.Text;

StringBuilder sb = new StringBuilder();
int s = 0;
int input = Int32.Parse(Console.ReadLine());
for (int i = 0; i < input; i++)
{
    string[] inputs = Console.ReadLine().Split();
    switch (inputs[0])
    {
        case "all":
            s = (1 << 21) - 1;
            break;
        case "empty":
            s = 0;
            break;
        default:
            int bit = Int16.Parse(inputs[1]);
            switch (inputs[0])
            {
                case "add":
                    s |= (1 << bit);
                    break;
                case "remove":
                    s &= ~(1 << bit);
                    break;
                case "check":
                    sb.AppendLine((s & (1 << bit)) != 0 ? 1.ToString() : 0.ToString());
                    break;
                case "toggle":
                    s ^= (1 << bit);
                    break;
            }
            break;

    }
}
Console.WriteLine(sb.ToString());