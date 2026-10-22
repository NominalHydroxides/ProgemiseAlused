using System.Globalization;

namespace SwitchTöö
{
    internal class Program
    {
        static void MethodActionDogBark()
        {
            Console.WriteLine("Auh!");
        }
        static void Main(string[] args)
        {
            // Teeme menüü
            Console.WriteLine("Tegevuse valimine");
            Console.WriteLine("1 - Liitmine");
            Console.WriteLine("2 - Koera hääl");
            Console.WriteLine("3 - Nimed");
            Console.WriteLine("Sisesta number (1-3): ");

            // Loeb kasutaja sisendi stringina
            string inputAction = Console.ReadLine();

            // Kasutab switch lauset valiku tegemiseks
            switch (inputAction)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Sisesta esimene arv: ");
                    // Esimene arv, parsitakse string andmetüübist andmetüüpi float
                    string firstInputNumber = Console.ReadLine();
                    float firstInputNumberParsedFormat = float.Parse(firstInputNumber);
                    Console.WriteLine("Sisesta teine arv: ");
                    // Teine arv, parsitakse string andmetüübist andmetüüpi float
                    string secondInputNumber = Console.ReadLine();
                    float secondInputNumberParsedFormat = float.Parse(secondInputNumber);
                    float additionOutput = firstInputNumberParsedFormat + secondInputNumberParsedFormat;
                    Console.WriteLine($"Tehte tulemus: {additionOutput}");
                    break;

                case "2":
                    Console.Clear();
                    MethodActionDogBark();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Mis su nimi on?");
                    string userName = Console.ReadLine();
                    if (userName == "Adolf Hitler")
                    {
                        Console.WriteLine("SIEG HEIL!");
                    }
                    else if (userName == "Benjamin Netanyahu")
                    {
                        Console.WriteLine("Oh hell nah!");
                        System.Environment.Exit();
                    }
                    else
                    {
                        Console.WriteLine($"Sinu nimi on {userName}");
                    }
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("VIGA: Tundmatu sisend. Proovi uuesti.");
                    break;
            }
        }
    }
}
