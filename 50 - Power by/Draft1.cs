public class Solution {
    public double MyPow(double x, int n) {
        if (x==1) return 1;
        if (n == 0) return 1;
        if (x==-1) return (n%2 == 0) ? 1 : -1;

        if (n == Int32.MinValue) {
            return 1 / (MyPow(x, Int32.MaxValue) * x);
        }

        double Result = x;
        int Loopcount = Math.Abs(n); 

        for(int i = 1; i < Loopcount; i++){
            Result = Result * x;
        }

        if (n < 0){
            Result = 1 / Result;
        }
        return Result;
    }
}