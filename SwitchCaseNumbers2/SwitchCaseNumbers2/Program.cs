namespace SwitchCaseNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nulliga lõppev arv (10; 20; 30), mis ei ole null: ");

            string inputNumberEndingInZero = Console.ReadLine();

            int parsedNumberEndingInZero = int.Parse(inputNumberEndingInZero);

            switch (parsedNumberEndingInZero)
            {
                case 10:
                    Console.WriteLine($"Sisestasid arvu {parsedNumberEndingInZero}.");
                    break;

                case 20:
                    Console.WriteLine($"Sisestasid arvu {parsedNumberEndingInZero}");
                    break;

                case 30:
                    Console.WriteLine($"Sisestasid arvu {parsedNumberEndingInZero}");
                    break;

                default:
                    Console.WriteLine($"Sisestasid muu arvu. Arvuks on {parsedNumberEndingInZero}");
                    break;
            }
        }
    }
}
