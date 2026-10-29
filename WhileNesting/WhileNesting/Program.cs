using System.Drawing;

namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While-tüüpi iteratsioonide pesastamine.");

            int i = 0;
            while (i <= 100)
            {
                int j = 0;
                while (j <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("[telliskivi]");
                    Thread.Sleep(1);
                    j++;
                    Console.ResetColor();
                }
                i++;
            }
        }
    }
}
