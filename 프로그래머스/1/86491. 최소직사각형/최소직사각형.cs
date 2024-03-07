using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int maxF = 0;
        int maxS = 0;
        for(int i=0; i< sizes.GetLength(0); i++){
            maxF = Math.Max(maxF, Math.Max(sizes[i,0],sizes[i,1]));
            maxS = Math.Max(maxS, Math.Min(sizes[i,0],sizes[i,1]));
        }
        answer = maxF * maxS;
        return answer;
    }
}