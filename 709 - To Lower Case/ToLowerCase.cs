public class Solution {
    public string ToLowerCase(string s) {
        string LowerString = "";
        
        for(int i = 0; i < s.Length; i++){
            char currentCharacter = s[i];
                if (currentCharacter >= 'A' && currentCharacter <= 'Z') {
                    currentCharacter = (char)(currentCharacter + ('a' - 'A'));
                }
                LowerString += currentCharacter;
        }
        return LowerString; 
    }
}

public class Solution {
    public string ToLowerCase(string s) 
    {
        return s.ToLower();
    }
}