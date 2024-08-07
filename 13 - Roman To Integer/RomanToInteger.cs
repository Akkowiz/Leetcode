public class Solution {
    Dictionary<char, int> dictionary_latin = new Dictionary<char, int>(){
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
            if(i == s.Length - 1){
                result += dictionary_latin[s[i]];
            }
            else if(dictionary_latin[s[i]] < dictionary_latin[s[i + 1]]){
                int subtracted = dictionary_latin[s[i + 1]] - dictionary_latin[s[i]];
                result += subtracted;
                i++;
            }
            else{
                result += dictionary_latin[s[i]];
            }
        }
    return result;
    }
}