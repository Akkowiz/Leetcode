public class Solution {
    public int MaximumWealth(int[][] accounts) {
    int HighestWealth = 0; 
    int AmountPeople = accounts.Length; 
    
        for(int i = 0; i < AmountPeople; i++){
            int CurrentWealth = accounts[i].Sum();
            HighestWealth = HighestWealth < CurrentWealth ? CurrentWealth : HighestWealth;
        }
    
    return HighestWealth;   
    }
}