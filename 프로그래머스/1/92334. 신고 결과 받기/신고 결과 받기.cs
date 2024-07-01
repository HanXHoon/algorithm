using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        

            var tempReport = report.Distinct()                                  //중복제거
                                    .Select(s => s.Split(' '))                  //space를 기준으로 split
                                    .GroupBy(g => g[1])                         //신고당한 사람[1]을 기준으로 그루핑
                                    .Where(w => w.Count() >= k)                 //k번 이상으로 신고당한 사람만 필터링
                                    .SelectMany(sm => sm.Select(s => s[0]))     //그 사람들을 신고한 사람을 필터링
                                    .ToList();
        
        return id_list.Select(s => tempReport.Where(w => w == s).Count()).ToArray();
    }
}