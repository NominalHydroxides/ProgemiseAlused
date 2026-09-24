namespace IfAndElseColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Teha If ja Else konsoolirakendus, kus kontrollitakse stringi abil värvi vastavust.

            // Värvide valikuks on: Red, Blue, Green ja White.

            // Peab käsitlema juhust, kus vastaja ei sisesta eelpool sisestatud värvi.

            Console.WriteLine("Sisesta värv. Valikus on Red, Blue, Green ja White.");

            // Programm jääb siin ootama, kuni kasutaja trükib teksti ja vajutab Enter.
            // Samuti paneb programm ülaregistris teksti alaregistrisse.
            string insertedColor = Console.ReadLine().ToLower();

            if (insertedColor == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valisid punase!");
                Console.ResetColor();
            }
            else if (insertedColor == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Valisid sinise!");
                Console.ResetColor();
            }
            else if (insertedColor == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisid rohelise!");
                Console.ResetColor();
            }
            else if (insertedColor == "white")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Valisid valge!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Tundmatu värv! Vali Red, Blue, Green või White.");
            }
        }
    }
}
