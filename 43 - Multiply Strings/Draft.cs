public class Solution {
    public string Multiply(string num1, string num2) {
        int Num1 = 0;
        int Num2 = 0;

        for(int i = 0, j = 0; i < num1.Length; i++){
            int tempNumber = num1[i] - '0';
            Num1 = Num1 * 10;
            Num1 += tempNumber;
        }

        for(int j = 0; j < num2.Length; j++){
            int tempNumber = num2[j] - '0';
            Num2 = Num2 * 10;
            Num2 += tempNumber;
        }

        int Result = Num1 * Num2;
        string ResultString = Result.ToString();
        return ResultString;
    }
}