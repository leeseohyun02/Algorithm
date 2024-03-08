public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int lowerMax = (int)'z';
        int upperMax = (int)'Z';
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(c != ' ')
            {
                int ic = (int)c + n;
                if(char.IsUpper(c) && ic > upperMax || ic > lowerMax)
                {
                    ic -= 26;
                }
                c = (char)ic;
            }
            answer += c;
        }
        return answer;
    }
}