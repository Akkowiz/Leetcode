public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int HighestWealth = 0; 

        for(int i = 0; i < accounts.Length; i++){
            int CurrentWealth = 0;

            for(int j = 0; j < accounts[i].Length; j++){
                CurrentWealth += accounts[i][j];
            }

            HighestWealth = HighestWealth < CurrentWealth ? CurrentWealth : HighestWealth;
        }
    
    return HighestWealth;   
    }
}