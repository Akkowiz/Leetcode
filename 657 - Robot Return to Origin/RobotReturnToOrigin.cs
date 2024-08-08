public class Solution {
    public bool JudgeCircle(string moves) {
        int xAxis = 0;
        int yAxis = 0;
        char[] Directions = moves.ToCharArray(); 

        for(int i = 0; i < Directions.Count(); i++){
            switch (Directions[i]){
            case 'L':
                xAxis --;
                break;
            case 'R':
                xAxis += 1;
                break;
            case 'U':
                yAxis += 1;
                break;
            case 'D':
                yAxis -= 1;
                break;
            }
        }
        bool Result = (xAxis == 0 && yAxis == 0) ? true : false;
        return Result;
    }
}