namespace ForKiriKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiri Koll");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill-koll");
                    Thread.Sleep(382);
                }

                Console.WriteLine("killadi-koll");
                Thread.Sleep(496);
            }
        }
    }
}
