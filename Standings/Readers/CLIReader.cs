namespace Standings.Readers
{
    public class CLIReader : InputReader
    {
        public string? readInput(string? source = null)
        {
            string result = "";
            string line;

            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                if (result == "") result = line;
                else result = result + Environment.NewLine + line;
            }
            return result;
        }
    }
}
