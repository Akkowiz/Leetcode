
public class Solution {
    public bool LemonadeChange(int[] bills) {
        List<int> SpareChange = new List<int>();

        foreach(int bill in bills){
            if(bill == 5){
                SpareChange.Add(bill);
            }
            else if(bill == 10){
                int Dollar5 = SpareChange.Count(n => n == 5);
                if(Dollar5 >= 1){
                    SpareChange.Remove(5);
                    SpareChange.Add(bill);
                }
                else{
                    return false;
                }
            }
            else if(bill == 20){
                int Dollar5 = SpareChange.Count(n => n == 5);
                int Dollar10 = SpareChange.Count(n => n == 10);
                if(Dollar10 >= 1 && Dollar5 >= 1){
                    SpareChange.Remove(10);
                    SpareChange.Remove(5);
                    SpareChange.Add(20);
                }
                else if(Dollar5 >= 3){
                    SpareChange.Remove(5);
                    SpareChange.Remove(5);
                    SpareChange.Remove(5);
                    SpareChange.Add(20);
                }
                else{
                    return false;
                }
            }
        }
        return true;
    }
}