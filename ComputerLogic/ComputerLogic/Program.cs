namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double firstCalculationOutput = 3 + 8 / (4 - 2) * 4;
            double secondCalculationOutput = 3 + 8 / 4 - 2 * 4;
            double thirdCalculationOutput = (3 + 8) / (4 - 2) * 4;
            double fourthCalculationOutput = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;


            Console.WriteLine($"3 + 8 / (4 - 2) * 4 = {firstCalculationOutput}");
            Console.WriteLine($"3 + 8 / 4 - 2 * 4 = {secondCalculationOutput}");
            Console.WriteLine($"(3 + 8) / (4 - 2) * 4 = {thirdCalculationOutput}");
            Console.WriteLine($"(3.0 + 8.0) / (4.0 - 2.0) * 4.0 = {fourthCalculationOutput}");
        }
    }
}
