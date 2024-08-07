public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int LastWordLength = 0;
        
        while(i >= 0 && s[i] == ' '){
            i--;
        }
        while(i >= 0 && !(s[i] == ' ')){
            LastWordLength++;
            i--;
        }
        return LastWordLength;
    }
}