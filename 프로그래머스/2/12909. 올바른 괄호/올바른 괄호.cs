using System;

public class Solution {
    public bool solution(string s) {
        int cnt = 0;
        for(int i = 0 ; i < s.Length ; i++){
            if(s[i] == '('){
                cnt++;
            }else{
                if(cnt == 0) return false;
                cnt--;
            }
            
        }
        return cnt == 0;
    }
}