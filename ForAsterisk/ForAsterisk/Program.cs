namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For-tüüpi iteratsioonid 2.");

            // Console prompts the user to enter the desired amount of lines.
            Console.WriteLine("Sisesta ridade arv: ");
            // The input is registered as a string called amountOfLines.
            string amountOfLines = Console.ReadLine();
            // String amountOfLines is parsed into an integer called nominalAmountOfIterations.
            int nominalAmountOfIterations = int.Parse(amountOfLines);

            // Iteration statement For: The following statement is iterated (repeatedly executed) until the console has printed enough lines (The amount of printed lines matches the integer value of nominalAmountOfIterations).
            for (int i = 0; i < nominalAmountOfIterations; i++)
            {
                Console.WriteLine("*");
                Thread.Sleep(100);
            }
        }
    }
}
