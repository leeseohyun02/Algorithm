using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
         
        while(n>0)
        {
            answer += n%10; // 123 -> 12.3 3값 더해짐 ,  12.3 -> 1.2 2값 더해짐, 
                            // 1.2->0.1 1값 더해짐
            n = n/10;       // 소수점 잘라낼 수 있음
        }
        return answer;
    }
}