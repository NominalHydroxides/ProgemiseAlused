namespace SwitchNumericalRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta arv: ");

            string inputNumber = Console.ReadLine();

            int inputNumberParsedFormat = int.Parse(inputNumber);

            switch (inputNumberParsedFormat)
            {
                case >= 0 and <= 100:
                    Console.WriteLine($"Sisestasid arvu {inputNumberParsedFormat} - Vahemik 0-100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine($"Sisestasid arvu {inputNumberParsedFormat} - Vahemik 101-200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine($"Sisestasid arvu {inputNumberParsedFormat} - Vahemik 201-300");
                    break;

                default:
                    Console.WriteLine($"Sisestasid arvu {inputNumberParsedFormat} - Tundmatu vahemik");
                    break;
            }
        }
    }
}
