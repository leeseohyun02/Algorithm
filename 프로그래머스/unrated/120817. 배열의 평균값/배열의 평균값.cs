using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        int num = 0;
        for(int i=0; i<numbers.Length;i++){ // 0부터 시작이므로 i<numbers.Length , 배열은 Length
            num += numbers[i];
        }
        answer = (double) num / (double) numbers.Length;
        return answer;
    }
}