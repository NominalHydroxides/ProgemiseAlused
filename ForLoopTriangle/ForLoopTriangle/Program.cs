namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest täisnurkne kolmnurk");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Sisesta ridade arv: ");

            string amountOfLinesNominal = Console.ReadLine();
            int nominalAmountOfIterations = int.Parse(amountOfLinesNominal);

            for (int i = 1; i <= nominalAmountOfIterations; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
