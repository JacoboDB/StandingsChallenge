using Standings;


class Program
{
    static void Main()
    {
        bool continueLoop = false;
        Console.WriteLine("---- Team Standings ----");
        do
        {
            Console.WriteLine("Please select the origin of your results:");
            Console.WriteLine("1) From a file");
            Console.WriteLine("2) Console interface");
            Console.WriteLine("Type your selection: ");
            string inputOption = Console.ReadLine();

            if (inputOption == "1")// Read from file
            {
                Console.WriteLine("Type your path to the file: ");
                string filePath = Console.ReadLine();
                var fileReader = new FileReader();
                string? fileContent = fileReader.readInput(filePath);
                if (fileContent == null) break;

            }
            else if (inputOption == "2") // Read from cli
            {
            }
            else
            {
                continueLoop = true;
                Console.WriteLine("Option not available!");
            }

        } while (continueLoop);

    }
}
