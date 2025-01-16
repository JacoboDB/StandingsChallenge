using Standings.Readers;

namespace Standings
{
    public class FileReader : InputReader
    {
        public string? readInput(string? filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    return File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading the file - " + ex.ToString());
                    return null;
                }

            }
            else
            {
                return null;
            }
        }
    }
}
