public class Solution {
    public string Multiply(string num1, string num2) {
        if(num1 == "0" || num2 == "0") return "0";

        int num1Length = num1.Length;
        int num2Length = num2.Length;
        int[] resultArray = new int[num1Length + num2Length];

        for(int i = num1Length - 1; i >= 0; i--){
            int iNumber = num1[i] - '0';
            for (int j = num2Length - 1; j >= 0; j--){
                int jNumber = num2[j] - '0';
                int Product = iNumber * jNumber;

                int p1 = i + j;       
                int p2 = i + j + 1;  

                int sum = Product + resultArray[p2]; 
                resultArray[p2] = sum % 10;      
                resultArray[p1] += sum / 10;         
            }
        }

        StringBuilder result = new StringBuilder();
        foreach(int digit in resultArray){
            if(!(result.Length == 0 && digit == 0)){
                result.Append(digit);
            }
        }

        return result.Length == 0 ? "0" : result.ToString();
    }
}