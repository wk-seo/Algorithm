using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) 
    {        
        //동일한 유저에 대한 신고 횟수는 1회로 처리된다.
        //  -> report에서 중복값 제거
        report = report.Distinct().ToArray();
                
        //전체 유저 - 신고 받은 횟수 딕셔너리
        var report2 = new Dictionary<string, int>();
        //전체 유저, 신고 성사 횟수 딕셔너리
        var report3 = new Dictionary<string, int>();

        //report2, 3 등록, 횟수는 0으로 초기화
        for(int i = 0; i < id_list.Length; i++)
        {
            report2.Add(id_list[i], 0);
            report3.Add(id_list[i], 0);
        }
        
        //신고한 유저 - 신고된 유저 딕셔너리로하면 key값이 중복된다. 
        //거꾸로 해도 value도 중복됨 -> 각각 list로..
        
        List<string> reporter = new List<string>();
        List<string> reported = new List<string>();
        
        for(int i = 0; i < report.Length; i++)
        {
            string[] temp = report[i].Split();
            
            report2[temp[1]]++;
            reporter.Add(temp[0]);
            reported.Add(temp[1]);
        }
                
        for(int i = 0; i < id_list.Length; i++)
        {
            if(report2[id_list[i]] >= k)
            {
               for(int j = 0; j < reported.Count; j++)
               {
                   if(id_list[i]==reported[j])
                   {
                       report3[reporter[j]]++;
                   }
               }
                //여기가 잘못됐군 
                //report3[reporter[reported.IndexOf(id_list[i])]]++;
            }
        }
        
        int[] answer = report3.Values.ToArray();
        return answer;
    }
}