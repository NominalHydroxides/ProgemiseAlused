using System.Drawing;

namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jalanumbrid.");
            // Teha jalanumbri suurusest üks if ja else harjutus.
            // Esimene tingimus on jalanumbrid 30 - 33 (siin on tekst roheline).
            // Teine tingimus on jalanumbrid 34 - 38 (siin on tagataust valge).
            // Kolmas tingimus on jalanumbrid 39 - 44 (siin on tekst sinine ja tagataust kollane).
            // Neljas tingimus on 45 - 48 (siin teeb arvuti häält beep).
            // Kindlasti tuleb ära lahendada olukord, kus kasutatakse mõnda teist jalanumbrit.

            Console.Write("Sisesta jalanumber: ");
            int footSize = int.Parse(Console.ReadLine());

            if (footSize >= 30 && footSize <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Sinu jalanumber on {footSize}.");
                Console.ResetColor();
            }
            else if (footSize >= 34 && footSize <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Sinu jalanumber on {footSize}.");
                Console.ResetColor();
            }
            else if (footSize >= 39 && footSize <= 44)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Sinu jalanumber on {footSize}.");
                Console.ResetColor();
            }
            else if (footSize >= 45 && footSize <= 48)
            {
                Console.Beep();
                Thread.Sleep(1000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Sinu jalanumber on {footSize}, aga seda ei ole ettenähtud vahemikes.");
                Console.ResetColor();
            }
        }
    }
}
