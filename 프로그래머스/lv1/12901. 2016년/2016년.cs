using System;

public class Solution 
{
    public string solution(int a, int b) 
    {
        //요일 배열
        string[] week = { "THU","FRI", "SAT","SUN", "MON", "TUE", "WED"};
    
        //1~12월별 날짜 수
        //2016년 2월은 윤년 = 29
        int[] daynum = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        //하나의 수로 일자 환산
        int date = b;
        
        if(a > 1)
        {
            while(a > 1)
            {
                date += daynum[a-2];
                a--;
            }        
        }

        date %= 7;
            
        string answer = week[date];
        return answer;
        
        //16.5.31 == 화 31+28+31 ==151%7==4 ==화
        //16.6.1 == 수
        //16.6.2 == 목
        //16.6.3 == 금
        
        //1, 3, 5, 7, 8, 10, 12 = 31일
        //2 = 28일
        //4, 6, 9, 11 = 30일
        
        //16.1.1. = 1 == 
        //16.1.31. = 31
        //16.2.28. = 31+28
        //16.3.31. = 31+28+31
        //16.4.30. = 31+28+31+30
        //16.5.31. = 31+28+31+30+31 = 화
        
    }
}