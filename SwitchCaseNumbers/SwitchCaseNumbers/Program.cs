namespace SwitchCaseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number (peab olema täisarvuline):");

            int number = int.Parse(Console.ReadLine());
            // Teha switch rakendus, kus on kolm case'i.

            switch (number)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Sisestasid numbri {number}, mis on tõepoolest 1.");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Sisestasid numbri {number}, mis on tõepoolest 2.");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Sisestasid numbri {number}, mis on tõepoolest 3.");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sisestasid muu numbri.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
