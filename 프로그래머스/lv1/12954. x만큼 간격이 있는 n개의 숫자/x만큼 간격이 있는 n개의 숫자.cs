public class Solution {
    public long[] solution(int x, int n) 
    {
      	long[] answer = new long[n];
  long a=x;
  for(long i=0;i<n;i++){
      a=x+(i*x);
      answer[i]= a;}
	return answer;
    }
}