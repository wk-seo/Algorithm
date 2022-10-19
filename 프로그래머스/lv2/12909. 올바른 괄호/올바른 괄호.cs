using System;

public class Solution {
    public bool solution(string s) 
    {
        bool answer = true;
        //bool isDone = false;

        int cnt1 = 0;
        int cnt2 = 0;
        //int cnt = 0;
        //answer == true의 조건
        //1) 시작은 (이어야. 2) 열고 닫는 개수가 맞아야
        //근데 개수 맞아도 끝나는게 (면 꽝임
        
        //if(s[0]==')') return false;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(') {
                cnt1++;
            }
            
            else {
                cnt2++;
            }
            if(cnt2>cnt1) return false;
        }
        
        if(cnt1 != cnt2) return false;
        if(s[s.Length-1] == '(') return false;
        
        return answer;
    }
}