namespace Hjemmet
{
    public class RockPaperScissors
    {
        public void Start()
            {
                Random random = new Random();
                int spillerPoint = 0;
                int computerPoint = 0;
                bool spilIgang = true;

                Console.WriteLine("Velkommen til Sten, Saks, Papir!");
                Console.WriteLine("Skriv 'afslut' for at stoppe og se den samlede score.");

                while (spilIgang)
                {
                    Console.WriteLine($"\nStilling -> Dig: {spillerPoint} | Computer: {computerPoint}");
                    Console.Write("Vælg Sten, Saks eller Papir: ");
                    string brugerValg = Console.ReadLine().ToLower();

                    if (brugerValg == "afslut")
                    {
                        spilIgang = false;
                        continue;
                    }

                    // Validér input
                    if (brugerValg != "sten" && brugerValg != "saks" && brugerValg != "papir")
                    {
                        Console.WriteLine("Ugyldigt valg! Prøv igen.");
                        continue;
                    }

                    // Computeren vælger tilfældigt
                    string[] muligheder = { "sten", "saks", "papir" };
                    string computerValg = muligheder[random.Next(0, 3)];

                    Console.WriteLine($"Computeren valgte: {computerValg}");

                    // Afgør vinderen af runden
                    if (brugerValg == computerValg)
                    {
                        Console.WriteLine("Det er en uafgjort!");
                    }
                    else if ((brugerValg == "sten" && computerValg == "saks") ||
                             (brugerValg == "saks" && computerValg == "papir") ||
                             (brugerValg == "papir" && computerValg == "sten"))
                    {
                        Console.WriteLine("Du vandt runden!");
                        spillerPoint++;
                    }
                    else
                    {
                        Console.WriteLine("Computeren vandt runden!");
                        computerPoint++;
                    }
                }

                // Vis den samlede score til sidst
                Console.WriteLine("\n--- SPIL SLUT ---");
                Console.WriteLine($"Endelig score -> Dig: {spillerPoint} | Computer: {computerPoint}");

                if (spillerPoint > computerPoint) Console.WriteLine("Tillykke! Du vandt overordnet.");
                else if (computerPoint > spillerPoint) Console.WriteLine("Computeren vandt samlet denne gang.");
                else Console.WriteLine("Det blev helt lige!");
            }
        }
    }