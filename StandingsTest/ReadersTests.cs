using Standings;
using Standings.Readers;

namespace StandingsTest
{
    public class ReadersTests
    {

        [Fact]
        public void ReadInputFromCLIWithSimulatedInput()
        {
            string simulatedInput = $"Foxes 4, Warriors 0{Environment.NewLine}Lions 8, Wheels 8{Environment.NewLine}";
            string expectedOutput = "Foxes 4, Warriors 0" + Environment.NewLine + "Lions 8, Wheels 8";

            var stringReader = new StringReader(simulatedInput);
            Console.SetIn(stringReader);

            InputReader reader = new CLIReader();
            string? result = reader.readInput();

            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ReadInputFromCLIWithEmptySimulatedInput()
        {
            string simulatedInput = "";
            var stringReader = new StringReader(simulatedInput);
            Console.SetIn(stringReader);

            InputReader reader = new CLIReader();
            string? result = reader.readInput();

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReadInputFromFileWithSimulatedInput()
        {
            string tempFilePath = Path.GetTempFileName();
            string expectedFileContent = "Lions 3, Snakes 3";
            File.WriteAllText(tempFilePath, expectedFileContent);
            InputReader reader = new FileReader();
            string? result = reader.readInput(tempFilePath);
            Assert.Equal(expectedFileContent, result);
            File.Delete(tempFilePath);
        }

        [Fact]
        public void ReadInputFromFileWhenFileDoesNotExists()
        {
            string nonExistingFilePath = "nonexistentfile.txt";
            InputReader reader = new FileReader();
            string? result = reader.readInput(nonExistingFilePath);
            Assert.Null(result);
        }
    }
}