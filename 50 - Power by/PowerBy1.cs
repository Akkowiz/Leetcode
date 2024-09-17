public class Solution {
    public double MyPow(double x, int n) {
        if (x==1) return 1;
        if (n == 0) return 1;
        if (x==-1) return (n%2 == 0) ? 1 : -1;

        if (n == Int32.MinValue) {
            return 1 / (MyPow(x, Int32.MaxValue) * x);
        }

        double Result = 1;
        long absoluteN = Math.Abs(n); 

    while (absoluteN > 0) {
            if (absoluteN % 2 == 1) {
                Result *= x;
            }
            x *= x;
            absoluteN /= 2;
        }

        if (n < 0){
            Result = 1 / Result;
        }
        return Result;
    }
}