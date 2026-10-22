namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta soovitud kolmnurga ridade arv: ");

            string amountOfLines = Console.ReadLine();
            int amountOfLinesParsedFormat = int.Parse(amountOfLines);

            if (amountOfLinesParsedFormat > 0)
            {
                int lineIncrement = 1;

                // Välimine tsükkel
                do
                {
                    int columnIncrement = 1;

                    // Sisemine tsükkel
                    do
                    {
                        Console.Write("*");
                        columnIncrement++;
                    } while (columnIncrement <= lineIncrement);

                    Console.WriteLine();
                    lineIncrement++;

                } while (lineIncrement <= amountOfLinesParsedFormat);
            }
            else
            {
                Console.WriteLine("Palun sisesta arv, mis on suurem kui 0.");
            }
        }
    }
}
