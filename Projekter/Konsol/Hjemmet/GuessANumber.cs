namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            Console.WriteLine("Velkommen til 'Gæt et tal'!");

                // 1. Opretter en tilfældighedsgenerator
                Random random = new Random();
                // Genererer et tal fra 1 til 100 (101 er eksklusiv)
                int hemmeligtTal = random.Next(1, 101);

                // Liste til at gemme alle gæt
                List<int> gaetListe = new List<int>();
                int brugerensGaet = 0;

                Console.WriteLine("Jeg har tænkt på et tal mellem 1 og 100.");

                // Loopet kører indtil brugeren gætter rigtigt
                while (brugerensGaet != hemmeligtTal)
                {
                    Console.Write("Indtast dit gæt: ");
                    string input = Console.ReadLine();

                    // Validering: Tjekker om input er et tal
                    if (int.TryParse(input, out brugerensGaet))
                    {
                        // Gemmer gættet i listen
                        gaetListe.Add(brugerensGaet);

                        if (brugerensGaet < hemmeligtTal)
                        {
                            Console.WriteLine("Det rigtige tal er højere!");
                        }
                        else if (brugerensGaet > hemmeligtTal)
                        {
                            Console.WriteLine("Det rigtige tal er lavere!");
                        }
                        else
                        {
                            Console.WriteLine($"\nTillykke! Du gættede rigtigt. Tallet var {hemmeligtTal}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt input. Venligst indtast et tal.");
                    }
                }

                // Viser alle gæt gemt i listen til sidst
                Console.WriteLine("\nHer er alle dine gæt:");
                Console.WriteLine(string.Join(", ", gaetListe));
                Console.WriteLine($"Du brugte i alt {gaetListe.Count} forsøg.");
                Console.ReadKey();
        }
        }
    }
