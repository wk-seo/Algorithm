using System.Collections.Generic;

int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> sums  = new List<int>();
for(int i = 0; i<inputs[0]-2; i++){
    for(int j = i+1; j<inputs[0]-1; j++){
        for(int k = j+1; k<inputs[0]; k++){
            if(nums[i]+nums[j]+nums[k]<=inputs[1]) 
                sums.Add(nums[i]+nums[j]+nums[k]);
        }
    }
}

Console.WriteLine(sums.Max());