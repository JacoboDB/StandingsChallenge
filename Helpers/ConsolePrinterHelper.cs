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

        public static void selectionMessage()
        {
            Console.WriteLine("Type your path to the file: ");
        }

        public static void standingsTable(Dictionary<string, int> standings)
        {
            int position = 1;
            Console.WriteLine("== STANDINGS ==");
            foreach (var team in standings)
            {
                Console.WriteLine(position + ". " + team.Key + ", " + team.Value + " pts");
                position++;
            }
        }
    }
}
