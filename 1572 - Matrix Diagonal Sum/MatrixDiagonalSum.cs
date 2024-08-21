public class Solution {
    public int DiagonalSum(int[][] mat) {
        int MatrixRow = mat.Length;
        int MatrixRowIndex = MatrixRow - 1;
        int DiagonalSums = 0;

        for(int i = 0; i < MatrixRow; i++){
            for(int j = 0; j < MatrixRow; j++){
                if(i == j || i + j == MatrixRowIndex){
                    DiagonalSums += mat[i][j];
                }
            }
        }
        return DiagonalSums;
    }
}