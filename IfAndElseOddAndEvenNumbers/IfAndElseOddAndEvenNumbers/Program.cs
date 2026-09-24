namespace IfAndElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Muutuja, mis kirjeldab arvu olekut (Täisarv või mitte).
            bool isAnInteger = false;

            // Tsükkel: Programm kordab kõike seni, kuni isAnInteger väärtus on false.
            while (!isAnInteger)
            {
               // Konsool küsib numbrit.
               Console.WriteLine("Sisesta üks täisarv:");

               // Kasutaja sisestab numbri stringina.
               string numberInput = Console.ReadLine();

               // Programm parsib sisestatud numbri täis- või ujukomaarvuks.
               double numberParsedFormat = double.Parse(numberInput);

               // If ja Else juures toimub kontroll, kas arv on paarisarv, paaritu arv, või ujukomaarv (ratsionaal- või irratsionaalarv).
               if (numberParsedFormat % 1 != 0)
               {
                    // Kutsub välja meetodi SayNumberNotAnInt(), mis ütleb, et arv ei ole täisarv.
                   SayNumberNotAnInt();
               }
               else if (numberParsedFormat % 2 == 0)
               {
                    // Kutsub välja meetodi SayNumberEven(), mis ütleb, et arv on paarisarv.
                    // Muutuja isAnInteger väärtus on true, see tähendab, et arv on paaris või paaritu täisarv.
                   SayNumberEven();
                    isAnInteger = true;
               }
               else
               {
                    // Kutsub välja meetodi SayNumberOdd(), mis ütleb, et arv on paaritu arv.
                    // Muutuja isAnInteger väärtus on true, see tähendab, et arv on paaris või paaritu täisarv.
                   SayNumberOdd();
                    isAnInteger = true;
               }
            }
        }
        static void SayNumberNotAnInt()
        {
            Console.WriteLine("VIGA: Sisestati ujukomaarv, kuigi programm küsis täisarvu.");
        }

        static void SayNumberEven()
        {
            Console.WriteLine("Sisestatud arv on paarisarv.");
        }

        static void SayNumberOdd()
        {
            Console.WriteLine("Sisestatud arv on paaritu arv.");
        }
    }
}
