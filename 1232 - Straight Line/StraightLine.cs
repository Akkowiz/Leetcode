public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if (coordinates.Length <= 2) return true;
        
        int Point0X = coordinates[0][0];
        int Point0Y = coordinates[0][1];
        int Point1X = coordinates[1][0];
        int Point1Y = coordinates[1][1];
        
        int IncreaseX = Point1X - Point0X;
        int IncreaseY = Point1Y - Point0Y;
        
        for (int i = 2; i < coordinates.Length; i++) {
            int PointIX = coordinates[i][0];
            int PointIY = coordinates[i][1];

            if ((PointIY - Point1Y) * IncreaseX != (PointIX - Point1X) * IncreaseY) {
                return false;
            }
        }
        
        return true;
    }
}

