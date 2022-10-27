int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputs[0];
int k = inputs[1];
int j = n-1;
int count = 0;
int[] coins = new int[n];

for(int i = 0; i < n; i++){
    coins[i] = int.Parse(Console.ReadLine());
}
Array.Sort(coins);

while(k!=0){
   if(k == 0) break;
   if(coins[j]>k) j--;
   else{
       k-=coins[j];
       count++;
   }
}
Console.WriteLine(count);