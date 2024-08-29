public class Solution {
    public bool LemonadeChange(int[] bills) {
        int Dollar5 = 0;
        int Dollar10 = 0;

        foreach(int bill in bills){
            if(bill == 5){
                Dollar5++;
            }
            else if(bill == 10){

                if(Dollar5 >= 1){
                    Dollar5--;
                    Dollar10++;
                }
                else{
                    return false;
                }
            }
            else if(bill == 20){
                if(Dollar10 >= 1 && Dollar5 >= 1){
                    Dollar10--;
                    Dollar5--;
                }
                else if(Dollar5 >= 3){
                    Dollar5 -= 3;
                }
                else{
                    return false;
                }
            }
        }
        return true;
    }
}
