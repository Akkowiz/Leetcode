public class Solution {
    public int CountOdds(int low, int high) {
        int TheOddOnes = 0;
        int Difference = high - low;

            if(Difference % 2 == 1){ // 1 odd number + 1 even number
                TheOddOnes = (Difference + 1) / 2;
            }
            else if(low % 2 == 1 && high % 2 == 1){ // both odd numbers
                TheOddOnes = (Difference / 2) + 1;
            }
            else{ // both even
                TheOddOnes = Difference / 2;
            }

        return TheOddOnes;
    }
}