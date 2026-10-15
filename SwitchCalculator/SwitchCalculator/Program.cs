namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv: ");

            string firstInputNumber = Console.ReadLine();
            float firstInputNumberParsedFormat = float.Parse(firstInputNumber);

            Console.WriteLine("Kasuta tehte operaatori märki (*, /, +, -): ");

            string mathematicalOperator = Console.ReadLine();

            Console.WriteLine("Sisesta teine arv: ");

            string secondInputNumber = Console.ReadLine();
            float secondInputNumberParsedFormat = float.Parse(secondInputNumber);

            switch (mathematicalOperator)
            {
                case "*":
                    Console.Clear();
                    float multiplicationOutput = firstInputNumberParsedFormat * secondInputNumberParsedFormat;
                    Console.WriteLine($"Tehte tulemus: {multiplicationOutput}");
                    break;

                case "/":
                    if (secondInputNumberParsedFormat == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Tekkis viga tehte töötlemisel: Keelatud matemaatiline operatsioon. Nulliga jagamine ei ole võimalik.");
                    }
                    else
                    {
                        Console.Clear();
                        float divisionOutput = firstInputNumberParsedFormat / secondInputNumberParsedFormat;
                        Console.WriteLine($"Tehte tulemus: {divisionOutput}");
                    }
                    break;

                case "+":
                    Console.Clear();
                    float additionOutput = firstInputNumberParsedFormat + secondInputNumberParsedFormat;
                    Console.WriteLine($"Tehte tulemus: {additionOutput}");
                    break;

                case "-":
                    Console.Clear();
                    float subtractionOutput = firstInputNumberParsedFormat - secondInputNumberParsedFormat;
                    Console.WriteLine($"Tehte tulemus: {subtractionOutput}");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Tekkis viga tehte töötlemisel.");
                    break;
            }
        }
    }
}
