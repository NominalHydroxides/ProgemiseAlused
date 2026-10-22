namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Switch");


            try
            {
                string inputNumber = Console.ReadLine();
                int inputNumberParsedFormat = int.Parse(inputNumber);

                switch (inputNumberParsedFormat)
                {
                    case 1:
                        Console.WriteLine($"Valisid numbri {inputNumberParsedFormat}");
                        break;

                    case 2:
                        Console.WriteLine($"Valisid numbri {inputNumberParsedFormat}");
                        break;
                }
            }
            // FormatException - Formaadi viga
            catch (FormatException)
            {
                Console.WriteLine("VIGA: Sisend ei vasta parsitavale andmetüübile. (FormatException)");
            }
            // Kui number on suurem kui int andmetüübi 32 bitti
            catch (OverflowException)
            {
                Console.WriteLine("VIGA: Number on liiga suur. (OverflowException)");
            }
        }
    }
}
