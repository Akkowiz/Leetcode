public class Solution
{
    public int CalPoints(string[] operations)
    {
        List<int> Scores = new List<int>();

        for (int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int NewScore))
            {
                Scores.Add(NewScore);
            }
            else
            {
                switch (operations[i])
                {
                    case "D":
                        int ScoreD = Scores[Scores.Count - 1] * 2;
                        Scores.Add(ScoreD);
                        break;
                    case "C":
                        Scores.RemoveAt(Scores.Count - 1);
                        break;
                    case "+":
                        int ScorePlus = Scores[Scores.Count - 2] + Scores[Scores.Count - 1];
                        Scores.Add(ScorePlus);
                        break;
                }
            }
        }
        int FinalScore = Scores.Sum();
        return FinalScore;
    }
}