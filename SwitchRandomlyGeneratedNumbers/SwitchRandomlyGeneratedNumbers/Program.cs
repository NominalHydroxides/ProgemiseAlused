namespace SwitchRandomlyGeneratedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");

            int diceRandomGenNumber = new Random().Next(1, 7);

            switch (diceRandomGenNumber)
            {
                case 1:
                    Console.WriteLine($"Viskasid täringut ja said numbriks {diceRandomGenNumber}. Paistab, et õnn pole täna sinu poolel.");
                    break;
                case 2:
                    Console.WriteLine($"Viskasid täringut ja said numbriks {diceRandomGenNumber}. Proovi Jumalalt õnne paluda.");
                    break;
                case 3:
                    Console.WriteLine($"Viskasid täringut ja said numbriks {diceRandomGenNumber}. Pole paha.");
                    break;
                case 4:
                    Console.WriteLine($"Viskasid täringut ja said numbriks {diceRandomGenNumber}. See juba läheb.");
                    break;
                case 5:
                    Console.WriteLine($"Viskasid täringut ja said numbriks {diceRandomGenNumber}. Sa oled võidule lähemal rohkem kui arvata oskad.");
                    break;
                case 6:
                    Console.WriteLine($"Viskasid täringut ja said numbriks {diceRandomGenNumber}. No tuli ära! Vedas sul.");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
