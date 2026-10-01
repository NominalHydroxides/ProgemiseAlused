namespace IfAndElseTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Majade suurused/pindalad.");

            Console.Write("Sisesta oma maja suurus/pindala: ");
            int houseSurfaceArea = int.Parse(Console.ReadLine());

            // ESIMENE KONTROLL: Majade suurused/pindalad vahemikus 0-40 ruutmeetrit.
            if (houseSurfaceArea >= 0 && houseSurfaceArea <= 40)
            {
                Console.WriteLine($"Sinu maja suurus/pindala on {houseSurfaceArea} ruutmeetrit.");
            }
            // TEINE KONTROLL: Majade suurused/pindalad vahemikus 41-90 ruutmeetrit.
            else if (houseSurfaceArea >= 41 && houseSurfaceArea <= 90)
            {
                Console.WriteLine($"Sinu maja suurus/pindala on {houseSurfaceArea} ruutmeetrit.");
            }
            // KOLMAS KONTROLL: Majade suurused/pindalad vahemikus 91-130 ruutmeetrit.
            else if (houseSurfaceArea >= 91 && houseSurfaceArea <= 130)
            {
                Console.WriteLine($"Sinu maja suurus/pindala on {houseSurfaceArea} ruutmeetrit.");
            }
            // NELJAS KONTROLL: Majade suurused/pindalad suuremad kui 131 ruutmeetrit.
            else if (houseSurfaceArea >= 131)
            {
                Console.WriteLine($"Sinu maja suurus/pindala on {houseSurfaceArea} ruutmeetrit.");
            }
            // Kui kasutaja sisestab negatiivse täisarvu.
            else
            {
                Console.WriteLine($"VIGA: Sisestati negatiivse väärtusega pindala. Sisestati pindala {houseSurfaceArea}, aga pindala väärtus peab olema 0 või sellest suurem täisarv.");
            }
        }
    }
}
