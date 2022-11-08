using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int mul = 1;
        int okCount = 0;

        while(okCount<arr.Length){
            okCount = 0;
            for(int i = 0; i<arr.Length; i++){
                if(arr.Max()*mul % arr[i] == 0) okCount++;
                else break;
            }
            if(okCount == arr.Length) break;
            mul++;
        }
        
        int answer = arr.Max()*mul;
        return answer;
    }
}