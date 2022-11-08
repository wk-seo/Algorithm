public class Solution {
    public int solution(int n) 
    {
        int a = 0;
        int b = 1;
        int c = 0;
        
        for(int i = 2; i  <= n; i++){
            c = (b+a)%1234567;
            a = b;
            b = c;
        }
        return c;
    }
}