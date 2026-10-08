namespace SwitchMethodCall
{
    internal class Program
    {
        static void MethodActionDogBark()
        {
            Console.WriteLine("Auh!");
        }
        static void MethodActionSayWantsToSleep()
        {
            Console.WriteLine("Ma tahan magada!");
        }
        static void MethodActionSayWantsToLearn()
        {
            Console.WriteLine("Ma tahan õppida!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine.");

            // Menüü valikud.
            Console.WriteLine("Vali tegevus:");
            Console.WriteLine("1 - Auh (MethodActionDogBark)");
            Console.WriteLine("2 - Tahab magada (MethodActionSayWantsToSleep)");
            Console.WriteLine("3 - Tahab õppida (MethodActionSayWantsToLearn)");
            Console.Write("Sisesta number (1-3): ");

            // Loeb kasutaja sisendi tekstina.
            string inputAction = Console.ReadLine();

            // Kasutab switch-lauset valiku tegemiseks.
            switch (inputAction)
            {
                case "1":
                    MethodActionDogBark(); // Kutsub esile meetodi MethodActionDogBark.
                    break;
                case "2":
                    MethodActionSayWantsToSleep(); // Kutsub esile meetodi MethodActionSayWantsToSleep.
                    break;
                case "3":
                    MethodActionSayWantsToLearn(); // Kutsub esile meetodi MethodActionSayWantsToLearn.
                    break;
                default:
                    // Kui sisestati vale valik.
                    Console.WriteLine($"VIGA: Tundmatu valik. Valik {inputAction} ei ole valikute nimekirjas.");
                    break;
            }
        }
    }
}
