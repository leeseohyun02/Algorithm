public class Solution {
    public int solution(int num) {
         int answer = 0;
         long Num = num;
    
        while(Num != 1)
        {
            if(answer >= 500) return -1;
            Num = Num % 2 == 0 ?  Num / 2 : (Num * 3) + 1 ;
            answer++;
        }      
        return answer;
    }
}