namespace ForKiriKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiri Koll");

            Console.WriteLine("Sisesta soovitud korduste arv: ");
            string inputNominal = Console.ReadLine();
            int nominalAmountOfMostOuterIterations = int.Parse(inputNominal);

            for (int n = 1; n <= nominalAmountOfMostOuterIterations; n++)
            {
                Console.WriteLine("See on rida nr {0}", n);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill-koll");
                    Thread.Sleep(382);
                }

                Console.WriteLine("killadi-koll");
                Thread.Sleep(496);

            }
        }
    }
}
