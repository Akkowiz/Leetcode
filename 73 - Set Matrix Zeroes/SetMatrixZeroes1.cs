public class Solution {
    public void SetZeroes(int[][] matrix) {
        int MatrixHeight = matrix.Length;
        int MatrixWidth = matrix[0].Length;
        List<int> ZeroY = new List<int>();
        List<int> ZeroX = new List<int>();


        for(int y = 0; y < MatrixHeight; y++){
            for(int x = 0; x < MatrixWidth; x++){
                if(matrix[y][x] == 0){
                    ZeroY.Add(y);
                    ZeroX.Add(x);
                }
            }
        }

        for(int i = 0; i < ZeroY.Count; i++){
            for(int y = 0; y < MatrixHeight; y++){
                int x = ZeroX[i];
                matrix[y][x] = 0;
            }
            for(int x = 0; x < MatrixWidth; x++){
                int y = ZeroY[i];
                matrix[y][x] = 0;
            }
        }
    }
}