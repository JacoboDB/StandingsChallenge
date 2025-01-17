
namespace Standings.Helpers
{
    public static class ConsolePrinterHelper
    {

        public static void startMessage()
        {
            Console.WriteLine("---- Team Standings ----");
        }

        public static void instructionsMessage()
        {
            Console.WriteLine("Please select the origin of your results:");
            Console.WriteLine("1) From a file");
            Console.WriteLine("2) Console interface");
            Console.WriteLine("Type your selection: ");
        }

        public static void exitMessage()
        {
            Console.WriteLine("---- Bye ----");
        }

        public static void filePathMessage()
        {
            Console.WriteLine("Type your path to the file: ");
        }

        public static void cliInputMessage()
        {
            Console.WriteLine("Enter the results match by match (press Enter on an empty line to finish):");
        }

        public static void standingsTable(Dictionary<string, int> standings)
        {
            int position = 1;
            Console.WriteLine("== STANDINGS ==");
            foreach (var team in standings)
            {
                Console.WriteLine(position + ". " + team.Key + ", " + team.Value + " " + getPointsText(team.Value));
                position++;
            }
        }

        private static string getPointsText(int points)
        {
            if (points == 1) return "pt";
            else return "pts";
        }

        internal static void incorrectInputMessage()
        {
            Console.WriteLine("Ooops! It looks like the entered text does not have the correct format. Please review.");
        }
    }
}
