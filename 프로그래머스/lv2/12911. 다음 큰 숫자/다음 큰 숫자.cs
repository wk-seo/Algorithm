using System;

class Solution 
{
    public int solution(int n) {
        int n2 = n+1;
        while(ConvertCount(n) != ConvertCount(n2)){
            if(ConvertCount(n) == ConvertCount(n2)) break;
            n2++;
        }
        return n2;
    }
    
    public int ConvertCount(int n){
        int count = 0;
        while(n>0){
            if(n%2 == 1) count++;
            n /= 2;      
            if(n==0) break;
        }
        return count;
    }
}