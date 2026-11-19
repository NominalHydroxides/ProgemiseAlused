namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play rock paper scissors!");

            Random random = new Random();

            string playerChoice = "";
            int playerPoints = 0;
            int computerPoints = 0;

            while (playerChoice != "lõpeta")
            {
                Console.WriteLine("Vali: kivi, paber või käärid.");
                Console.WriteLine("Mängu lõpetamiseks kirjuta: lõpeta");
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "lõpeta")
                {
                    break;
                }
                if (playerChoice != "kivi" &&
                    playerChoice != "paber" &&
                    playerChoice != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole, proovi uuesti.");
                    continue;
                }

                int computerNumber = random.Next(1, 4);
                string computerChoice = "";

                if (computerNumber == 1)
                {
                    computerChoice = "kivi";
                }
                else if (computerNumber == 2)
                {
                    computerChoice = "paber";
                }
                else
                {
                    computerChoice = "käärid";
                }

                Console.WriteLine($"Arvuti valis:{computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Viik!");
                }
                else if ((playerChoice == "kivi" && computerChoice == "käärid") ||
                        (playerChoice == "paber" && computerChoice == "kivi") ||
                        (playerChoice == "käärid" && computerChoice == "paber"))
                {
                    Console.WriteLine("Sina võitsid!");
                    playerPoints++;
                }
                else
                {
                    Console.WriteLine("Arvuti võitis!");
                    computerPoints++;
                }

                Console.WriteLine($"Punktid: sina {playerPoints} -- arvuti: {computerPoints}");
                Console.WriteLine();
            }

            Console.WriteLine("Mäng on läbi!");
            Console.WriteLine($"Lõpptulemus: sina {playerPoints} -- arvuti {computerPoints}");
        }
    }
}
