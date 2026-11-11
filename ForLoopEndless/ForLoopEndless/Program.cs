namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trololo");

            // Teha for loopiga lõputu tsükkel, mis prindib konsooli "i väärtus on: number"

            short i = 1;

            for (; ; )
            {
                Console.WriteLine($"i väärtus on: {i}");

                if (i == 10)
                {
                    break;
                }

                i++;
            }
        }
    }
}
