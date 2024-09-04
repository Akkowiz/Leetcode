public class Solution {
    public string AddBinary(string a, string b) {
        int StringA = a.Length - 1;
        int StringB = b.Length - 1;
        string BinaryString = "";
        int CarryOver = 0;

        for (int i = StringA, j = StringB; i >= 0 || j >= 0; i--, j--) {
            int A = (i >= 0) ? (int)char.GetNumericValue(a[i]) : 0; 
            int B = (j >= 0) ? (int)char.GetNumericValue(b[j]) : 0; 
            int CurrentSum = A + B + CarryOver;
            CarryOver = 0;
            switch (CurrentSum) {
                case 0:
                    BinaryString = "0" + BinaryString;
                    break;
                case 1:
                    BinaryString = "1" + BinaryString;
                    break;
                case 2:
                    BinaryString = "0" + BinaryString;
                    CarryOver = 1;
                    break;
                case 3:
                    BinaryString = "1" + BinaryString;
                    CarryOver = 1; 
                    break;
            }
        }
        if (CarryOver > 0) {
            BinaryString = "1" + BinaryString;
        }
        return BinaryString;
    }
}
