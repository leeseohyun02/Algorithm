using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int Min = arr.Min();
        int[] answer = arr.Where(x => x != Min).ToArray();
            
        if(arr.Length == 1){
            answer = new int[] {-1};
        }
        
        return answer;
    }
}