namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For-tüüpi iteratsioonid.");

            int nominalAmountOfIterations = 10;

            // int i on muutuja määratlemine ja selle väärtus on 0
            // i < nominalAmountOfIterations iga kord võrdleb nominalAmountOfIterations muutujat, et kas on suurem i-st
            // i++ liidab iga kord ühe korra juurde e sama hea kui i + 1

            for (int i = 0; i < nominalAmountOfIterations; i++)
            {
                Console.WriteLine($"See on {i}-s iteratsioon.");
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
