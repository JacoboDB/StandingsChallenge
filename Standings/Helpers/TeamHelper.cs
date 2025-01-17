namespace Standings.Helpers
{
    public static class TeamHelper
    {

        public static string formTeamName(string[] teamName)
        {
            string teamNameResult = "";
            for (int i = 0; i < teamName.Length - 1; i++)
            {
                teamNameResult += " " + teamName[i];
            }
            return teamNameResult.Trim();
        }

        public static int getScoreFromTeam(string[] teamScore)
        {
            return int.Parse(teamScore[teamScore.Length - 1]);
        }

        public static int calculatePointsForTheTeam(int team1Score, int team2Score)
        {
            if (team1Score > team2Score)
            {
                return 3;
            }
            else if (team2Score > team1Score)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
