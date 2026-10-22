namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            string inputNumber = Console.ReadLine();
            int inputNumberParsedFormat = int.Parse(inputNumber);
            int incrementValue = 1;

            do
            {
                Console.WriteLine(incrementValue);
                // ++ liidab ühe numbri juurde eelnevale (++ on increment)
                incrementValue++;
            } while (incrementValue <= inputNumberParsedFormat);
        }
    }
}
