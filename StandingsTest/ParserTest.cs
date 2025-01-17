using Standings.Parser;

namespace StandingsTest
{
    public class ParserTest
    {

        [Fact]
        public void ParseShouldReturnStandings()
        {
            string inputText = $"Foxes 4, Galactic Warriors 0{Environment.NewLine}Lions 8, Wheels 8";
            var expectedStandings = new Dictionary<string, int>
            {
                { "Foxes", 3 },
                { "Lions", 1 },
                { "Wheels", 1 },
                { "Galactic Warriors", 0 }
            };

            var parser = new MatchParser();
            var result = parser.parse(inputText);
            Assert.Equal(expectedStandings, result);
        }

        [Fact]
        public void ParseShouldReturnEmptyStandingsWhenEmptyInput()
        {
            string inputText = "";
            var parser = new MatchParser();
            var result = parser.parse(inputText);
            Assert.Empty(result);
        }
    }
}
