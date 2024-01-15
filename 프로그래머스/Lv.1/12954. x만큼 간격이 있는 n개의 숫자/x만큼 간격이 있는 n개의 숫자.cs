public class Solution {
    public long[] solution(int x, int n) { 
        
        long[] answer = new long[n]; 
        
        for(int i=0; i<n; i++){
            answer[i] = (long)(i+1) * x;
        }
        return answer;
    }
} // x의 제한 조건이 int 형 n의 연산결과가 표현범위를 벗어나 에러가 남
  // 그래서 long형으로 형변환 매개변수의 타입을 바꾸는 것보단 활용이 더 좋음