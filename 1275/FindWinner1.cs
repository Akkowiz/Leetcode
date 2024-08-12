public class Solution {
    public string Tictactoe(int[][] moves) {
        string Result = System.String.Empty;
        if(moves.Length <= 4){
            return Result = "Pending";
        }
        List<string> PlayerA = new List<string> {"A"};
        List<string> PlayerB = new List<string> {"B"};
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

    if(string.IsNullOrEmpty(Result)){
        Result = CheckWinCondition(PlayerA);
    }

    if(string.IsNullOrEmpty(Result)){
        Result = CheckWinCondition(PlayerB);
    }

    if(string.IsNullOrEmpty(Result) && moves.Length == 9){
        Result = "Draw";
    }

    if(string.IsNullOrEmpty(Result) && moves.Length < 9){
        Result = "Pending";
    }
    
 static string CheckWinCondition(List<string> Player)
    {
        // Checks horizontal win conditions
         if(Player.Contains("0,0") && Player.Contains("0,1") && Player.Contains("0,2") || 
            Player.Contains("1,0") && Player.Contains("1,1") && Player.Contains("1,2") || 
            Player.Contains("2,0") && Player.Contains("2,1") && Player.Contains("2,2")){
            return Player[0];
            }
        // Checks vertical win conditions
        if(Player.Contains("0,0") && Player.Contains("1,0") && Player.Contains("2,0") || 
            Player.Contains("0,1") && Player.Contains("1,1") && Player.Contains("2,1") || 
            Player.Contains("0,2") && Player.Contains("1,2") && Player.Contains("2,2")){
            return Player[0];
            }
        // Checks diagonal win conditions
        if(Player.Contains("0,0") && Player.Contains("1,1") && Player.Contains("2,2") || 
            Player.Contains("0,2") && Player.Contains("1,1") && Player.Contains("2,0")){
            return Player[0];
            }
        else{
            return null;
        }

    }
    return Result;
    }
}