public class Solution {
    Dictionary<char, int> dictionaryLatin = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    public int RomanToInt(string s){
        int result = 0;

        for(int i = 0; i < s.Length; i++){
            int currentLetter = dictionaryLatin[s[i]];

            if(i == s.Length - 1){
                result += currentLetter;
            } 
            else if(currentLetter < dictionaryLatin[s[i + 1]]){
                int subtracted = dictionaryLatin[s[i + 1]] - currentLetter;
                result += subtracted;
                i++;
            }
            else{
                result += currentLetter;
            }
        }
        return result;
    }
}

