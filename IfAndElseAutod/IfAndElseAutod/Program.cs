using System.Security.Cryptography.X509Certificates;

namespace IfAndElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kasutada if ja else tingimuslauseid.
            // Kirjuta automark.
            // Valikus on BMW, Audi, Porsche, Fiat ja Škoda.
            // Kui valitakse Škoda, siis seal sees on uuesti küsimus, et mis mudelit soovid valida. Mudeli valikus on Kodiaq ja Octavia.

            Console.WriteLine("Mis autot osta tahad? Meie valikus on BMW, Audi, Porsche, Fiat, ja Škoda.");

            string carManufacturer = Console.ReadLine();

            if (carManufacturer == "BMW")
            {
                Console.WriteLine("Tahad osta BMW'd. Oled vist kõva bemmivend.");
            }
            else if (carManufacturer == "Audi")
            {
                Console.WriteLine("Tahad osta Audit. Austus sulle.");
            }
            else if (carManufacturer == "Porsche")
            {
                Console.WriteLine("Tahad osta Porschet. See on hea automark.");
            }
            else if (carManufacturer == "Fiat")
            {
                Console.WriteLine("Tahad osta Fiati. Loodetavasti mitte Fiat Multiplat.");
            }
            else if (carManufacturer == "Mercedes Benz")
            {
                Console.WriteLine("Meie valikus ei ole hetkel Mercedes Benzi autosid.");
            }
            else if (carManufacturer == "Opel")
            {
                Console.WriteLine("Meie valikus ei ole hetkel Opeli autosid. Varsti tuleb üks heas seisukorras Opel Calibra 4x4 Turbo.");
            }
            else if (carManufacturer == "Lamborghini")
            {
                Console.WriteLine("Me ei müü Lamborghini autosid.");
            }
            else if (carManufacturer == "Tesla")
            {
                Console.WriteLine("Me ei müü prügikaste, tähendab Teslasid.");
            }
            else if (carManufacturer == "Toyota")
            {
                Console.WriteLine("Meie valikus ei ole hetkel Toyota autosid.");
            }
            else if (carManufacturer == "Rolls Royce")
            {
                Console.WriteLine("Me ei müü Rolls Royce autosid.");
            }
            else if (carManufacturer == "Scania")
            {
                Console.WriteLine("Me ei müü veokeid. Mine Scania esindusse, kui tahad omale Scaniat osta.");
            }
            else if (carManufacturer == "Škoda")
            {
                Console.WriteLine("Tahad osta Škodat. Millist mudelit täpsemalt? Kodiaq või Octavia?");

                string skodaModel = Console.ReadLine();

                if (skodaModel == "Kodiaq")
                {
                    Console.WriteLine("Tahad osta Škoda Kodiaqi. Kõva värk.");
                }
                else if (skodaModel == "Octavia")
                {
                    Console.WriteLine("Tahad osta Škoda Octaviat. Ajatu klassika, ausalt.");
                }
                else
                {
                    Console.WriteLine("Meie autovalikus ei ole muid Škoda mudeleid.");
                }
            }
            else
            {
                Console.WriteLine($"Me ei müü {carManufacturer} autosid.");
            }
        }
    }
}
