using Standings;
using Standings.Helpers;
using Standings.Parser;
using Standings.Readers;


class Program
{
    static InputReader? fileReader;
    static void Main()
    {
        bool continueLoop = false;
        string inputOption = "";
        ConsolePrinterHelper.startMessage();

        //C:\\Users\\Jacob\\OneDrive\\Escritorio\\results.txt
        do
        {
            ConsolePrinterHelper.instructionsMessage();
            inputOption = Console.ReadLine();
            if (inputOption != "1" || inputOption != "2")
            {
                continueLoop = true;
                Console.WriteLine("Option not available!");
            }

        } while (continueLoop);

        string? fileContent = null;
        if (inputOption == "1")// Read from file
        {
            ConsolePrinterHelper.selectionMessage();
            string filePath = Console.ReadLine();
            fileReader = new FileReader();
            fileContent = fileReader.readInput(filePath);

        }
        else if (inputOption == "2") // Read from cli
        {
        }

        if (fileContent != null)
        {
            var standings = new MatchParser().parse(fileContent);
            ConsolePrinterHelper.standingsTable(standings);
        }

        ConsolePrinterHelper.exitMessage();

    }
}
