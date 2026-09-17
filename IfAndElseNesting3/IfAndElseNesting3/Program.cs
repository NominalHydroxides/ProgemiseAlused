namespace IfAndElseNesting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja Else tingimuslausete pesastamine 3.");
            // Konsool küsib numbrit.
            // Kasutaja sisestab numbri.
            // If võrdub 12.
            // Else if ja siia sisse omakorda teha if ning else. Else if tingimus on, et
            // muutuja on suurem kui 20.
            // Else ja seal väljastab konsool teksti: Mingid kahtlased väärtused.

            Console.Write("Sisesta number: ");
            int y = int.Parse(Console.ReadLine());

            if (y == 12)
            {
                // Kui Y väärtus on 12, siis konsool väljastab teksti: Y võrdub 12.
                Console.WriteLine("Y võrdub 12");
            }
            else if (y > 20)
            {
                if (y == 23)
                {
                    // Kui Y väärtus on suurem kui 20 ja on 23, siis konsool väljastab teksti: Y võrdub 23.
                    Console.WriteLine("Y võrdub 23");
                }
                else
                {
                    // Kui Y väärtus on suurem kui 20 ja on vahemikus 21 kuni 22 ning 24 kuni lõpmatus, siis konsool väljastav teksti: Y on vahemikus 21 kuni 22 ja 24 kuni lõpmatus.
                    Console.WriteLine("Y on vahemikus 21 kuni 22 ja 24 kuni lõpmatus");
                }
            }
            else
            {
                // Kui Y väärtus ei kattu ülejäänud väärtustega, siis konsool väljastab teksti: Mingid kahtlased väärtused.
                Console.WriteLine("Mingid kahtlased väärtused");
            }
        }
    }
}