namespace IfAndElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esimene arv.
            Console.WriteLine("Sisesta esimene arv: ");

            string firstInputNumber = Console.ReadLine();
            float firstInputNumberParsedFormat = float.Parse(firstInputNumber);


            // Tehte operaator (tehtemärk).
            Console.WriteLine("Sisesta tehte operaatori märk: ");

            string mathematicalOperator = Console.ReadLine();


            // Teine arv.
            Console.WriteLine("Sisesta teine arv: ");

            string secondInputNumber = Console.ReadLine();
            float secondInputNumberParsedFormat = float.Parse(secondInputNumber);


            if (mathematicalOperator == "*")
            {
                Console.Clear();
                float multiplicationOutput = firstInputNumberParsedFormat * secondInputNumberParsedFormat;
                Console.WriteLine($"Tehte tulemus: {multiplicationOutput}");
            }
            else if (mathematicalOperator == "/")
            {
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
            }
            else if (mathematicalOperator == "+")
            {
                Console.Clear();
                float additionOutput = firstInputNumberParsedFormat + secondInputNumberParsedFormat;
                Console.WriteLine($"Tehte tulemus: {additionOutput}");
            }
            else if (mathematicalOperator == "-")
            {
                Console.Clear();
                float subtractionOutput = firstInputNumberParsedFormat - secondInputNumberParsedFormat;
                Console.WriteLine($"Tehte tulemus: {subtractionOutput}");
            }
            else
            {
                Console.WriteLine("Tekkis viga tehte töötlemisel.");
            }
        }
    }
}
