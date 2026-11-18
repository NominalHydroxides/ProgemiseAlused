namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");
            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis: ");

            string highestMultiplier = Console.ReadLine();
            int highestMultiplierParsedFormat = int.Parse(highestMultiplier);

            Console.WriteLine($"Korrutustabel ühest kuni {highestMultiplierParsedFormat}-ni");
            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= highestMultiplierParsedFormat; j++)
                {
                    Console.Write($"{j}x{i} = {j * i}, ");
                }

                Console.WriteLine();        
            }
        }
    }
}
