public class Solution {
    public bool IsRobotBounded(string instructions) {
        int y = 0;
        int x = 0;
        int FaceDirection = 0;

        for(int i = 0; i < instructions.Length; i++){
            if(instructions[i] == 'G'){
                switch(FaceDirection) 
                {
                case 0:
                    y++;
                    break;
                case 180:
                    y--;
                    break;
                case 90:
                    x++;
                    break;
                case 270:
                    x--;
                    break;
                }
            }
            else if(instructions[i] == 'L'){
                FaceDirection -= 90;
                if(FaceDirection < 0){
                    FaceDirection = 270;
                }
            }
            else if(instructions[i] == 'R'){
                FaceDirection += 90;
                if(FaceDirection >= 360){
                    FaceDirection = 0;
                }
            }
        } 
        if((x == 0 && y == 0) || FaceDirection != 0){
            return true;
        }
        else{
            return false;
        }
    }
}