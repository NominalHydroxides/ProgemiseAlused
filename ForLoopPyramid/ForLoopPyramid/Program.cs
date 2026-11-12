namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest võrdkülgne kolmnurk (2D püramiid)");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n\n");
            Console.Write("Sisesta ridade arv: ");

            string amountOfLinesNominal = Console.ReadLine();
            int nominalAmountOfIterations = int.Parse(amountOfLinesNominal);

            for (int i = 1; i <= nominalAmountOfIterations; i++)
            {
                for (int j = 1; j <= nominalAmountOfIterations - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
