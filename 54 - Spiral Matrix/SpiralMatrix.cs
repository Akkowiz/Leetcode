public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int MatrixHeight = matrix.Length;
        int MatrixWidth = matrix[0].Length;
        int TotalMoves = MatrixHeight * MatrixWidth;
        int[] Result = new int[TotalMoves];
        string Direction = "R";
        int CurrentMoves = 0;

        // indexed (-1), just like i or j
        int Left = 0; 
        int Top = 0; 
        int Right = MatrixWidth - 1;
        int Bottom = MatrixHeight - 1;

        while(CurrentMoves < TotalMoves){   
            switch(Direction){
                case "R":
                    for(int i = Left; i <= Right; i++){
                        Result[CurrentMoves]= matrix[Top][i];
                        CurrentMoves++;
                    }
                    Top++;
                    Direction = "D";
                    break;

                case "D":
                    for(int j = Top; j <= Bottom; j++){
                        Result[CurrentMoves]= matrix[j][Right];
                        CurrentMoves++;
                    }
                    Right--;
                    Direction = "L";
                    break;

                case "L":
                    for(int i = Right; i >= Left; i--){
                        Result[CurrentMoves]= matrix[Bottom][i];
                        CurrentMoves++;
                    }
                    Bottom--;
                    Direction = "U";
                    break;

                case "U":
                    for(int j = Bottom; j >= Top; j--){
                        Result[CurrentMoves]= matrix[j][Left];
                        CurrentMoves++;
                    }
                    Left++;
                    Direction = "R";
                    break;
            }
        }
        foreach (int Number in Result){
            Console.WriteLine(Number);
        }
        return Result;
    }
}