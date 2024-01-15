using System;

public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];
        
        for(int i = 0; i < str.Length; i++)
        {
            answer[i] = int.Parse(str[i].ToString()); //문자의 배열로 간주
        }
        Array.Reverse(answer);
        return answer;
    }
}