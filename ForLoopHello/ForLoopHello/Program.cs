namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Teha konsoolirakendus, kus kasutad For-tüüpi iteratsioone
            // Kolm korda näidatakse Tere tulemast ja lõpus on reanumber
            // Kasutaja ei tohi midagi sisestada

            int predeterminedAmountOfIterations = 3;

            for (int i = 0; i < predeterminedAmountOfIterations; i++)
            {
                Console.WriteLine($"Tere tulemast! Rea number: {i + 1}");
                Thread.Sleep(382);
            }
        }
    }
}
