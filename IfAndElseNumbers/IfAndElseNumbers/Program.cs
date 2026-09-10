using System.Threading.Channels;

namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number:");

            // Konsoolis sisestame numbri.
            // See number salvestatakse string andmetüüpi.
            // Toimub kontroll, kas sisestatud väärtus on täis- või ujukomaarv.
            // Kasutada if ja else tingimuslauseid.

            // Muutuja nimega number, kuhu salvestatakse kasutaja sisestatud tekst.
            string number = Console.ReadLine();

            // Kontrollime, kas sisestatud väärtus on täis- või ujukomaarv.
            if (double.TryParse(number, out double result))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Sisestasid numbri. Väga hea.");
                Console.WriteLine(number);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Midagi läks untsu :( Proovi uuesti.");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
