namespace IfAndElseMethodCall
{
    internal class Program
    {
        // Main on meetod, mis läheb alati esimesena tööle.
        static void Main(string[] args)
        {
            // 1. Küsi kasutajalt sisendit.
            Console.WriteLine("Sisesta praegune kellaaeg (täistund 0-23): ");

            // 2. Loe kasutaja sisestatud tekst.
            string timeInput = Console.ReadLine();

            // 3. Teisenda tekst täisarvuks (int).
            int timeOfDay = int.Parse(timeInput);

            // 4. Kutsu meetod välja ja saada kasutaja sisestatud arv meetodile HelloMethod.
            HelloMethod(timeOfDay);
        }

        // Teha teine meetod siia ja nimeks on sellel HelloMethod.

        static void HelloMethod(int timeHour)
        {
            if (timeHour < 12)
            {
                Console.WriteLine("Tere hommikust!");
            }
            else if (timeHour < 18)
            {
                Console.WriteLine("Tere päevast!");
            }
            else
            {
                Console.WriteLine("Tere õhtust!");
            }
        }
    }
}
