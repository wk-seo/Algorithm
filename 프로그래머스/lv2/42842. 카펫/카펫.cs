using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int brown, int yellow) 
    {
        int width = 0, height = 0, yw = 0, yh = 0;
        List<int> yksu = new List<int>();
                
        for(int i = 1; i <= yellow; i++)
        {
            if(yellow%i == 0) yksu.Add(i);
        }
        
        if(yksu.Count == 1) yh = yw = yksu[0];
        
        else if(yksu.Count%2 == 0)
        {
            yh = yksu[yksu.Count/2-1];
            yw = yksu[yksu.Count/2];
        }
                
        else
        {
            yh = yksu[yksu.Count/2];
            yw = yksu[yksu.Count/2];
        }

        width = yw+2;
        height = yh+2;
        
        for(int i = 1 ; width*height < yellow+brown; i++)
        {
            height = yksu[yksu.Count/2-1-i] +2;
            width = yksu[yksu.Count/2+i] +2;
        }
        
        
        int[] answer = {width, height};
        return answer;
    }
}