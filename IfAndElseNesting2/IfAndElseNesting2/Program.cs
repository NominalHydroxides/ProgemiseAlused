namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja Else tingimuslausete pesastamine.");
            // Pesastamine (Nesting) tähendab, et if-else struktuuride sees võib olla teisi if-else struktuure.
            // See võimaldab teha keerukamaid otsuseid ja kontrollida erinevaid tingimusi.

            int y = 10;

            if (y == 12)
            {
                Console.WriteLine("Y võrdub 12");
            }
            else if (y > 20)
            {
                if (y == 25)
                {
                    Console.WriteLine("Y võrdub 25");
                }
                else
                {
                    Console.WriteLine("Y on vahemikus 21 kuni 24 ja 26 kuni lõpmatus");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased numbrid jälle");
            }
        }
    }
}
