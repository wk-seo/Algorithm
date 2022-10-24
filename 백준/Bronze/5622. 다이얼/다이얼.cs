string input = Console.ReadLine();
string[] inputs = new string[input.Length];
int answer = 0;
for (int i = 0; i < input.Length; i++)
{
    inputs[i] = input.Substring(i, 1);
    if (inputs[i] == "A" || inputs[i] == "B" || inputs[i] == "C")
    {
        answer+=2;
    }
    else if (inputs[i] == "D" || inputs[i] == "E" || inputs[i] == "F")
    {
        answer+= 3;
    }
    else if (inputs[i] == "G" || inputs[i] == "H" || inputs[i] == "I")
    {
        answer+= 4;
    }
    else if (inputs[i] == "J" || inputs[i] == "K" || inputs[i] == "L")
    {
        answer+= 5;
    }
    else if (inputs[i] == "M" || inputs[i] == "N" || inputs[i] == "O")
    {
        answer+= 6;
    }
    else if (inputs[i] == "P" || inputs[i] == "Q" || inputs[i] == "R"||inputs[i]=="S")
    {
        answer+= 7;
    }
    else if (inputs[i] == "T" || inputs[i] == "U"||inputs[i] == "V")
    {
        answer+= 8;
    }
    else
    {
        answer+= 9;
    }
}
answer += input.Length;
Console.WriteLine(answer);