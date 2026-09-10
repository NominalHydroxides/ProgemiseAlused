namespace IfAndElse
{
    internal class Program
    {
        // Projekt nimetusega IfAndElse, mille sees asub class nimega Program.
        // See klass sisaldab Main meetodit, mis on programmi sisenemispunkt. 
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi:");

            // Muutuja nimega name, kuhu salvestatakse kasutaja sisestatud tekst.
            string name = Console.ReadLine();

            // ! tähendab "ei ole" ja == tähendab "on võrdne".
            if (name != "")
            {
                // Kui kasutaja sisestab midagi, siis muutub taustavärv roheliseks.
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Sisestasid enda nime. Väga sigma.");
                Console.WriteLine(name);
            }
            else
            {
                // Kui sisend (Sisestatud nimi) on vale või tühi, siis muutub taustavärv punaseks.
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Midagi läks untsu :( Proovi uuesti.");
                // Lisaks kostub 2 piiksu.
                Console.Beep();
                // Ja oodatakse 1 sekund enne programmi lõppu.
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
