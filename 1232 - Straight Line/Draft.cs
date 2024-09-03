public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if(coordinates.Length <= 2) return true;
        int TotalPoints = coordinates.GetLength(0) - 1;
        int IncreaseX = coordinates[1][0] - coordinates[0][0];
        int IncreaseY = coordinates[1][1] - coordinates[0][1];

        for(int i = 1; i < TotalPoints; i++){
            int NextX = coordinates[i][0] + IncreaseX;
            int NextY = coordinates[i][1] + IncreaseY;
            if(NextX != coordinates[i+1][0] || NextY != coordinates[i+1][1]) return false;
        }
        return true;
    }
}