using System;
using System.Collections.Generic;

class Solution
{
    int roundNum = 0;
    bool isDone = false;
    public int solution(int n, int a, int b)
    {
        List<int> game = new List<int>();
        
         for(int i = 0; i < n; i++){
            if(i+1 == a) game.Add(1);
            else if(i+1 == b) game.Add(1); 
            else game.Add(0);
         }
        
        while(!isDone){
            game = GameCount(game);
        }
        return roundNum;
    }
    
    public List<int> GameCount(List<int> list){
        List<int> list2 = new List<int>();
        roundNum++;
        for(int i = 0; i < list.Count-1; i+=2){
            if(list[i] == 1 && list[i+1] == 1) {
                list2 = list; 
                isDone = true;
                break;
            }
            if(list[i] == 1 && list[i+1] != 1){
                list2.Add(list[i]);
            }
            else if(list[i] != 1 && list[i+1] == 1){
                list2.Add(list[i+1]);
            }
            else{
                list2.Add(list[i]);
            }
        }
        return list2;
    }
            
}