using System;

public class Solution {
    public long solution(long N) {
        long answer = 0;       
        var n = Math.Ceiling(Math.Sqrt(N)); // n의 제곱근
                
            if(N/n == n){
                answer = (long)Math.Pow(n+1,2);
            }
            else{
            answer = -1;
            }
        
        
        return answer;
    }
}