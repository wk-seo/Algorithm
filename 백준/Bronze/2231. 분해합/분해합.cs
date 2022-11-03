int n = int.Parse(Console.ReadLine());
int start = 0;
bool isFound = false;

//생성자가 n보다 클 수도 있나? 없지 왜냐면 자기자신을 더하는디 어떻게 큼 
while (start< n)
{ 
    if (Ssum(start)+start == n) {
        isFound = true;
        break;
    }
    start++;
}

if(!isFound) start = 0;
Console.WriteLine(start);

int Ssum(int a){
    int result = 0;
        while (a > 0)
        {
            result += a % 10;
            a /= 10; 

        }
        return result;
}