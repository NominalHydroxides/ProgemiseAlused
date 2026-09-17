namespace IfAndElseNesting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja Else tingimuslausete pesastamine 3.");
            // Konsool küsib numbrit.
            // If võrdub 12.
            // Else if ja siia sisse omakorda teha if ning else. Else if tingimus on, et
            // muutuja on suurem kui 20.
            // Else ja seal väljastab konsool teksti: Mingid kahtlased väärtused.

            int y = 10;

            if (y == 12)
            {
                Console.WriteLine("Y võrdub 12");
            }
            else if (y > 20)
            {
                if (y == 23)
                {
                    Console.WriteLine("Y võrdub 23");
                }
                else
                {
                    Console.WriteLine("Y on vahemikus 21 kuni 22 ja 24 kuni lõpmatus");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased väärtused");
            }
        }
    }
}