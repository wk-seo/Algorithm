using System;

public class Solution {
    public int solution(int[] A, int[] B) 
    {
        Array.Sort(A); Array.Reverse(A);
        Array.Sort(B);
        int answer = 0;

        for(int i = 0; i < A.Length; i++)
        {
            answer += A[i]*B[i];
        }
        return answer;
    }
}