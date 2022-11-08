using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        List<string> history = new List<string>();
        int currNum = 0;
        int turn = 1;
        bool isFinish = false;
        for(int i = 0; i<words.Length;i++){
            currNum++;
            if(currNum>n) {
                currNum = 1;
                turn++;
            }
            if(i>0 &&history.Contains(words[i])){
                isFinish = true;
                break;
            }
            if(i>0 && words[i-1][words[i-1].Length-1] != words[i][0]){
                isFinish = true;
                break;
            }
        
            history.Add(words[i]);
        }
        
        if(isFinish){
            answer[0] = currNum; answer[1] = turn;
        }
        else{
            answer[0] = 0; answer[1] = 0;
        }
        
        
        return answer;
    }
}