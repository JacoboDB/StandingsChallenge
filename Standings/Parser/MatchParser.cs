using Standings.Helpers;

namespace Standings.Parser
{


    public class MatchParser
    {
        public Dictionary<string, int> standings;

        public MatchParser()
        {
            standings = new Dictionary<string, int>();
        }

        public Dictionary<string, int> parse(string input)
        {
            reset();
            if (string.IsNullOrEmpty(input)) return standings;
            var matchesResults = input.Split(Environment.NewLine).ToList();
            foreach (string match in matchesResults)
            {
                var teamsInMatch = match.Split(",");
                var teamName1Splited = teamsInMatch[0].Trim().Split(" ");
                var teamName2Splited = teamsInMatch[1].Trim().Split(" ");

                string team1 = TeamHelper.formTeamName(teamName1Splited);
                string team2 = TeamHelper.formTeamName(teamName2Splited);

                int team1Score = TeamHelper.getScoreFromTeam(teamName1Splited);
                int team2Score = TeamHelper.getScoreFromTeam(teamName2Splited);

                addToStandings(team1, TeamHelper.calculatePointsForTheTeam(team1Score, team2Score));
                addToStandings(team2, TeamHelper.calculatePointsForTheTeam(team2Score, team1Score));

            }
            standings = standings.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).ToDictionary<string, int>();
            return standings;
        }

        public void reset()
        {
            standings = new Dictionary<string, int>();
        }

        private void addToStandings(string teamName, int points)
        {
            if (standings.ContainsKey(teamName))
            {
                standings[teamName] += points;
            }
            else
            {
                standings.Add(teamName, points);
            }
        }


    }
}
