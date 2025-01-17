

using Standings.Helpers;

namespace StandingsTest
{
    public class HelpersTests
    {

        [Fact]
        public void FormTeamNameShouldReturnCorrectTeamName()
        {
            string[] inputTeam = { "FC", "Alligators ", "3" };
            string expectedResult = "FC Alligators";
            string result = TeamHelper.formTeamName(inputTeam);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void FormTeamNameShouldReturnEmptyString()
        {
            string[] inputTeam = { };
            string result = TeamHelper.formTeamName(inputTeam);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void FormTeamNameShouldReturnSingleWord()
        {
            string[] inputTeam = { "LAFC", "0" };
            string expected = "LAFC";
            string result = TeamHelper.formTeamName(inputTeam);
            Assert.Equal(expected, expected);
        }

        [Fact]
        public void GetScoreFromTeam()
        {
            string[] teamScore = { "Team A", "5" };
            int expected = 5;
            int result = TeamHelper.getScoreFromTeam(teamScore);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatePointsForTheTeamWinningTeamA()
        {
            int teamAScore = 3;
            int teamBScore = 1;
            int expectedPoints = 3;
            int pointsResult = TeamHelper.calculatePointsForTheTeam(teamAScore, teamBScore);
            Assert.Equal(expectedPoints, pointsResult);
        }

        [Fact]
        public void CalculatePointsForTheTeamWinningTeamB()
        {
            int teamAScore = 0;
            int teamBScore = 1;
            int expectedPoints = 0;
            int pointsResult = TeamHelper.calculatePointsForTheTeam(teamAScore, teamBScore);
            Assert.Equal(expectedPoints, pointsResult);
        }
        [Fact]
        public void CalculatePointsForTheTeamTie()
        {
            int teamAScore = 0;
            int teamBScore = 0;
            int expectedPoints = 1;
            int pointsResult = TeamHelper.calculatePointsForTheTeam(teamAScore, teamBScore);
            Assert.Equal(expectedPoints, pointsResult);
        }

        [Fact]
        public void StandingsTable()
        {
            var teamsStandings = new Dictionary<string, int>
            {
                { "Owls", 9 },
                { "Wolves FC", 1 },
                { "Dogs", 0 }
            };
            string expectedOutput = $"== STANDINGS =={Environment.NewLine}1. Owls, 9 pts{Environment.NewLine}2. Wolves FC, 1 pt{Environment.NewLine}3. Dogs, 0 pts{Environment.NewLine}";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            ConsolePrinterHelper.standingsTable(teamsStandings);
            string actualOutput = stringWriter.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}