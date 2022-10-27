int n = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(inputs);
//1, 2, 3, 3, 4
int result = 0;
int temp = 0;
for(int i = 0; i<n; i++){
    temp += inputs[i];
        result += temp;
}
//i == 0, temp = 1, result  = 1
//i == 1, temp = 1+2 = 3, result  = 4
//i == 2, temp = 3+3 = 6, result  = 10
//i == 3, temp = 6+3 = 9, result  = 19
//i == 4, temp = 9+4 = 13, result  = 32
Console.WriteLine(result);