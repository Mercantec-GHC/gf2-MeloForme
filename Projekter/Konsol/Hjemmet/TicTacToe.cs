namespace Hjemmet
{
    public class TicTacToe
    {
        public void Start()
        { }

             class Program
        {
            // Brættet gemmes som et array med 9 felter (1-9)
            static char[] braet = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            static int spiller = 1; // 1 for Spiller X, 2 for Spiller O
            static int valg; // Brugerens input

            static void Main()
            {
                int vinderStatus = 0; // 0 = køre, 1 = vinder, -1 = uafgjort

                do
                {
                    Console.Clear();
                    Console.WriteLine("Spiller 1: X  og  Spiller 2: O\n");
                    TegnBraet();

                    // Skift mellem spiller 1 og 2
                    if (spiller % 2 == 0) Console.Write("Spiller 2 (O), vælg felt: ");
                    else Console.Write("Spiller 1 (X), vælg felt: ");

                    // Læs input og tjek om det er et tal
                    bool korrektInput = int.TryParse(Console.ReadLine(), out valg);

                    if (korrektInput && valg >= 1 && valg <= 9 && braet[valg - 1] != 'X' && braet[valg - 1] != 'O')
                    {
                        braet[valg - 1] = (spiller % 2 == 0) ? 'O' : 'X';
                        spiller++;
                    }
                    else
                    {
                        Console.WriteLine("Ulovligt træk! Prøv igen.");
                        System.Threading.Thread.Sleep(1000);
                    }

                    vinderStatus = TjekVinder();

                } while (vinderStatus == 0);

                Console.Clear();
                TegnBraet();

                if (vinderStatus == 1) Console.WriteLine($"Tillykke! Spiller {(spiller % 2 == 0 ? "1 (X)" : "2 (O)")} har vundet!");
                else Console.WriteLine("Det blev uafgjort!");
            }

            // Metode til at tegne brættet i konsollen
            static void TegnBraet()
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {braet[0]}  |  {braet[1]}  |  {braet[2]}   ");
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {braet[3]}  |  {braet[4]}  |  {braet[5]}   ");
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {braet[6]}  |  {braet[7]}  |  {braet[8]}   ");
                Console.WriteLine("     |     |      \n");
            }

            // Metode til at tjekke om der er en vinder (1), uafgjort (-1) eller om spillet fortsætter (0)
            static int TjekVinder()
            {
                // Vandrette rækker
                if (braet[0] == braet[1] && braet[1] == braet[2]) return 1;
                if (braet[3] == braet[4] && braet[4] == braet[5]) return 1;
                if (braet[6] == braet[7] && braet[7] == braet[8]) return 1;

                // Lodrette rækker
                if (braet[0] == braet[3] && braet[3] == braet[6]) return 1;
                if (braet[1] == braet[4] && braet[4] == braet[7]) return 1;
                if (braet[2] == braet[5] && braet[5] == braet[8]) return 1;

                // Diagonale rækker
                if (braet[0] == braet[4] && braet[4] == braet[8]) return 1;
                if (braet[2] == braet[4] && braet[4] == braet[6]) return 1;

                // Tjek for uafgjort (hvis alle felter er fyldt)
                foreach (char felt in braet)
                {
                    if (felt != 'X' && felt != 'O') return 0;
                }

                return -1;
            }
        }
    }
}