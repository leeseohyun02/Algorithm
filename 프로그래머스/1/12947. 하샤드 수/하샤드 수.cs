using System;

public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int num=0;
        char[] X = x.ToString().ToCharArray();
        
        for(int i = 0; i < X.Length; i++){
            num += int.Parse(X[i].ToString());
        }
        
        if(x % num == 0) {answer = true;}            
        
        else {answer = false;}
                                            
        return answer;
    }
}