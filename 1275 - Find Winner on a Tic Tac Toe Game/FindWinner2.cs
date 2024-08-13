public class Solution {
    public string Tictactoe(int[][] moves) {

        if(moves.Length <= 4){
            return "Pending";
        }

        static bool CheckWinCondition(List<string> Player)
        {
        // Checks horizontal win conditions
        if(Player.Contains("0,0") && Player.Contains("0,1") && Player.Contains("0,2") || 
        Player.Contains("1,0") && Player.Contains("1,1") && Player.Contains("1,2") || 
        Player.Contains("2,0") && Player.Contains("2,1") && Player.Contains("2,2")){
            return true;
            }
        // Checks vertical win conditions
        if(Player.Contains("0,0") && Player.Contains("1,0") && Player.Contains("2,0") || 
        Player.Contains("0,1") && Player.Contains("1,1") && Player.Contains("2,1") || 
        Player.Contains("0,2") && Player.Contains("1,2") && Player.Contains("2,2")){
            return true;
            }
        // Checks diagonal win conditions
        if(Player.Contains("0,0") && Player.Contains("1,1") && Player.Contains("2,2") || 
        Player.Contains("0,2") && Player.Contains("1,1") && Player.Contains("2,0")){
            return true;
            }

        else{
            return null;
            }
        }

        List<string> PlayerA = new List<string>();
        List<string> PlayerB = new List<string>();
        string PlayerTurn = "A";

        foreach(var move in moves){
            string CurrentMove = $"{move[0]},{move[1]}";

            if(PlayerTurn == "A"){
                PlayerA.Add(CurrentMove);
                PlayerTurn = "B";
            }
            
            else if(PlayerTurn == "B"){
                PlayerB.Add(CurrentMove);
                PlayerTurn = "A";
            }
        }

        if(CheckWinCondition(PlayerA)){
            return "A";
        }

        else if(CheckWinCondition(PlayerB)){
            return "B";
        }

        else if(string.IsNullOrEmpty(Result) && moves.Length == 9){
            return "Draw";
        }

        else{
            return "Pending";
        }
    }
}