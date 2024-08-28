public class Solution {
    public void SetZeroes(int[][] matrix) {
        int MatrixRows = matrix.Length;
        int MatrixCols = matrix[0].Length;
        bool FirstRow = false;
        bool FirstCol = false;

        for(int x = 0; x < MatrixCols; x++){
            if(matrix[0][x] == 0){
                FirstRow = true;
                break;
            }
        }

        for(int y = 0; y < MatrixRows; y++){
            if(matrix[y][0] == 0){
                FirstCol = true;
                break;
            }
        }

        for(int y = 1; y < MatrixRows; y++){
            for(int x = 1; x < MatrixCols; x++){
                if(matrix[y][x] == 0){
                    matrix[y][0] = 0;
                    matrix[0][x] = 0;
                }
            }
        }

        for(int y = 1; y < MatrixRows; y++){
            for(int x = 1; x < MatrixCols; x++){
                if(matrix[y][0] == 0 || matrix[0][x] == 0){
                    matrix[y][x] = 0;
                }
            }
        }

        if(FirstRow){
            for(int x = 0; x < MatrixCols; x++){
                matrix[0][x] = 0;
            }
        }

        if(FirstCol){
            for(int y = 0; y < MatrixRows; y++){
                matrix[y][0] = 0;
            }
        }
    }
}
