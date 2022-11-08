using System;
using System.Collections.Generic;

public class Solution {
    
    int countZero = 0;
    int count = 0;
    
    public int[] solution(string s) 
    {
        int[] answer = new int[2];
        while(s!= "1"){
            s = Convert(s);
            if(s=="1") break;
        }
        
        answer[0] = count;
        answer[1] = countZero;

        return answer;
    }
    
    public string Convert(string s){
        
        int length = 0;
        List<string> results = new List<string>();
        
         for(int i = 0; i < s.Length; i++){
            if(s[i] == '1') length++;
        }
        
        countZero+= s.Length - length;
        
        while(length>0){
            results.Add((length%2).ToString());
            length /= 2;
            if(length == 0) break;
        }
        
        string result = "";
        for(int i = results.Count-1; i>= 0; i--){
            result+= results[i];
        }
        
        count++;
        
        return result;
        
    }
}