using System;
using System.Linq;

public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        
        //답 1 - 평균 소요시간 2.3ms
        //string kimIndex = seoul.Select((value, index) => new { value, index })
        //                    .First(f => f.value.Equals("Kim")).index.ToString();

        //답 2 - 평균 소요시간 0.6ms
        //string kimIndex = Array.FindIndex(seoul, s => s.Equals("Kim")).ToString();

        //답 3 - 평균 소요시간 1.2ms
        string kimIndex = seoul.ToList().IndexOf("Kim").ToString();
          
        answer = $"김서방은 {kimIndex}에 있다";
        return answer;
    }
}