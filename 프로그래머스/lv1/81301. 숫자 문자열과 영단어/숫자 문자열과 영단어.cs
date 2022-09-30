using System;

public class Solution {
    public int solution(string s)
    {
        //단어를 받음
        string [] words = 
        {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        //s에 단어가들어있는지 한별
        //string형 숫자로 치환함
        for(int i = 0; i < words.Length; i++)
        {
            if(s.Contains(words[i]))
            {
                s = s.Replace(words[i], i.ToString());
            }
        }
        
        //치환 완료한 string을 int로 변환
        int answer = int.Parse(s);
        return answer;
    }
}
