public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int LastWordLength = 0;

        // makes sure i points to the latest char that isnt empty
        while(i >= 0 && s[i] == ' '){
            i--;
        }
        
        // counts the amount of chars that arent empty, stops when it encounters an empty
        while(i >= 0 && !(s[i] == ' ')){
            LastWordLength++;
            i--;
        }
        return LastWordLength;
    }
}