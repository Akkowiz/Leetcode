public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int HighestWealth = 0; 
        int AmountPeople = accounts.Length; 
        int AmountBanks = accounts[0].Length;

        for(int i = 0; i < AmountPeople; i++){
            int CurrentWealth = 0;

            for(int j = 0; j < AmountBanks; j++){
                CurrentWealth += accounts[i][j];
            }
            HighestWealth = HighestWealth < CurrentWealth ? CurrentWealth : HighestWealth;
        }
    
        return HighestWealth;   
    }
}