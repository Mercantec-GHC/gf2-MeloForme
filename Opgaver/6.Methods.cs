using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Opgaver
{
    public class Methods
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Methods, Params, Return og Recursion!");
            
            // Grundlæggende methods
            Method1();
            Method2();
            Method3();
            
            // Parameter opgaver
            Parameter1();
            Parameter2();
            Parameter3();
            Parameter4();
            
            // Return value opgaver
            Return1();
            Return2();
            Return3();
            Return4();
            
            // Recursion opgaver
            Recursion1();
            Recursion2();
            
            // Mini-projekter
            MiniProjektLommeregner();
            MiniProjektTalSpil();
        }

        public static void Method1()
        {
            Console.WriteLine("Opgave 1 (Grundlæggende method):");
            Console.WriteLine("Lav en method der udskriver 'Hej verden!' og kald den fra denne method.");
            // Lav opgaven herunder!

            Console.WriteLine("Hej, verden!");
            Program program = new Program();
        }


        public static void Method2()
        {
            Console.WriteLine("Opgave 2 (Grundlæggende method):");
            Console.WriteLine("Lav en method der udskriver tallene fra 1 til 5 og kald den fra denne method.");
            // Lav opgaven herunder!

            for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            }

        public static void Method3()
        {
            Console.WriteLine("Opgave 3 (Grundlæggende method):");
            Console.WriteLine("Lav en method der beder brugeren om deres navn og hilser på dem, og kald den fra denne method.");
            // Lav opgaven herunder!

            Console.Write("Indtast dit navn: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");
        }

        public static void Parameter1()
        {
            Console.WriteLine("Opgave 4 (Parameter):");
            Console.WriteLine("Lav en method der tager et navn som parameter og udskriver 'Hej [navn]!'" );
            // Lav opgaven herunder!
            // Kald metoden med dit eget navn

            Console.WriteLine("Hej Aira!");
        }

        public static void Parameter2()
        {
            Console.WriteLine("Opgave 5 (Parameter):");
            Console.WriteLine("Lav en method der tager to tal som parametre og udskriver summen af dem.");
            // Lav opgaven herunder!

            static void PrintSum(int x, int y)
            {
                int result = x + y;
                Console.WriteLine($"{x} + {y} = {result}");
            }
            PrintSum(20, 26);
        }

        public static void Parameter3()
        {
            Console.WriteLine("Opgave 6 (Parameter):");
            Console.WriteLine("Lav en method der tager et tal som parameter og tjekker om det er lige eller ulige.");
            // Lav opgaven herunder!

            static void CheckParity(int n)
            {
                if (n % 2 == 0)
                    Console.WriteLine($"{n} er lige.");
                else
                    Console.WriteLine($"{n} er ulige.");
            }

            Console.Write("Indtast et tal: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                CheckParity(value);
            }
            else
            {
                Console.WriteLine("Ugyldigt tal. Indtast venligst et heltal.");
            }
        }

        public static void Parameter4()
        {
            Console.WriteLine("Opgave 7 (Flere parametre):");
            Console.WriteLine("Lav en method der tager navn, alder og by som parametre og udskriver en præsentation.");
            // Lav opgaven herunder!
        
            static void Present(string name, int age, string city)
            {
                Console.WriteLine($"Jeg hedder {name}, er {age} år gammel og kommer fra {city}.");
            }
            Present("Abekat", 25, "København");
            Present("Lone", 32, "Odense");
        }

        public static void Return1()
        {
            Console.WriteLine("Opgave 8 (Return value):");
            Console.WriteLine("Lav en method der tager to tal som parametre og returnerer summen. Udskriv resultatet.");
            // Lav opgaven herunder!

            int a = 5;
            int b = 3;

            int sum = Add(a, b);

            Console.WriteLine($"Summen af {a} og {b} er {sum}.");

            static int Add(int x, int y) => x + y;
        }


        public static void Return2()
        {
            Console.WriteLine("Opgave 9 (Return value):");
            Console.WriteLine("Lav en method der tager et tal som parameter og returnerer om det er lige (true/false).");
            // Lav opgaven herunder!

            static bool IsEven(int n) => n % 2 == 0;

            int evenExample = 4;
            int oddExample = 7;

            bool evenResult = IsEven(evenExample);
            bool oddResult = IsEven(oddExample);

            Console.WriteLine($"{evenExample} er lige? {evenResult}");
            Console.WriteLine($"{oddExample} er lige? {oddResult}");
        }

        public static void Return3()
        {
            Console.WriteLine("Opgave 10 (Return value):");
            Console.WriteLine("Lav en method der tager et navn som parameter og returnerer 'Hej [navn]!'" );
            // Lav opgaven herunder!

            static string Greet(string name) => $"Hej {name}!";
       
            string greeting1 = Greet("Abekat");
            string greeting2 = Greet("Lone");

            Console.WriteLine(greeting1);
            Console.WriteLine(greeting2);
        }

        public static void Return4()
        {
            Console.WriteLine("Opgave 11 (Return value):");
            Console.WriteLine("Lav en method der tager tre tal som parametre og returnerer det største tal.");
            // Lav opgaven herunder!

            static int MaxOfThree(int x, int y, int z) => Math.Max(x, Math.Max(y, z));

            int a = 5;
            int b = 12;
            int c = 9;

            int largest = MaxOfThree(a, b, c);
            Console.WriteLine($"Det største af {a}, {b} og {c} er {largest}.");
        }

        public static void Recursion1()
        {
            Console.WriteLine("Opgave 12 (Recursion):");
            Console.WriteLine("Lav en rekursiv method der beregner fakultet af et tal (f.eks. 5! = 5*4*3*2*1).");
            Console.WriteLine("Tip: Fakultet af n = n * fakultet af (n-1), og fakultet af 1 = 1");
            // Lav opgaven herunder!

            Console.Write("Indtast et ikke-negativt heltal: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int n) || n < 0)
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et ikke-negativt heltal.");
                return;
            }

            static long Factorial(int k)
            {
                if (k <= 1) return 1;
                checked
                {
                    return k * Factorial(k - 1);
                }
            }

            try
            {
                long result = Factorial(n);
                Console.WriteLine($"{n}! = {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Resultatet for {n}! overstiger grænsen for type 'long'. Prøv et mindre tal.");
            }
        }

        public static void Recursion2()
        {
            Console.WriteLine("Opgave 13 (Recursion):");
            Console.WriteLine("Lav en rekursiv method der tæller ned fra et givet tal til 0.");
            Console.WriteLine("Eksempel: CountDown(3) skal udskrive: 3, 2, 1, 0");

            Console.Write("Indtast et ikke-negativt heltal: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int n) || n < 0)
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et ikke-negativt heltal.");
                return;
            }

            static void CountDownRecursive(int k)
            {
                Console.Write(k);
                if (k > 0)
                {
                    Console.Write(", ");
                    CountDownRecursive(k - 1);
                }
                else
                {
                    Console.WriteLine();
                }
            }

            CountDownRecursive(n);
        }

        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Lommeregner med methods (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program med separate methods for de fire regnearter (+, -, *, /).");
            Console.WriteLine("Hver method skal tage to tal som parametre og returnere resultatet.");
            Console.WriteLine("Lav en hovedmethod der beder brugeren om to tal og en operation, og kalder den rigtige method.");
            // Lav opgaven herunder!

            static bool TryParseDouble(string? s, out double value)
            {
                value = 0;
                if (string.IsNullOrWhiteSpace(s)) return false;
                // Først standard parse (brugers kultur)
                if (double.TryParse(s, out value)) return true;
                // Prøv at normalisere til invariant (punktum) hvis komma bruges
                string alt = s.Replace(',', '.');
                return double.TryParse(alt, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out value);
            }
            static double Add(double x, double y) => x + y;
            static double Subtract(double x, double y) => x - y;
            static double Multiply(double x, double y) => x * y;
            static double Divide(double x, double y) => x / y;

            Console.Write("Indtast første tal: ");
            string? input1 = Console.ReadLine();
            if (!TryParseDouble(input1, out double n1))
            {
                Console.WriteLine("Ugyldigt tal. Afslutter lommeregneren.");
                return;
            }
            Console.Write("Indtast andet tal: ");
            string? input2 = Console.ReadLine();
            if (!TryParseDouble(input2, out double n2))
            {
                Console.WriteLine("Ugyldigt tal. Afslutter lommeregneren.");
                return;
            }
            Console.Write("Vælg operation (+, -, *, /): ");
            string? op = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(op))
            {
                Console.WriteLine("Ingen operation valgt. Afslutter.");
                return;
            }

            double result;
            switch (op.Trim())
            {
                case "+":
                    result = Add(n1, n2);
                    Console.WriteLine($"{n1} + {n2} = {result}");
                    break;
                case "-":
                    result = Subtract(n1, n2);
                    Console.WriteLine($"{n1} - {n2} = {result}");
                    break;
                case "*":
                case "x":
                case "X":
                    result = Multiply(n1, n2);
                    Console.WriteLine($"{n1} * {n2} = {result}");
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Fejl: Division med nul er ikke tilladt.");
                    }
                    else
                    {
                        result = Divide(n1, n2);
                        Console.WriteLine($"{n1} / {n2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Ugyldig operation. Brug +, -, * eller /.");
                    break;
            }
        }

        public static void MiniProjektTalSpil()
        {
            Console.WriteLine("\nMini-projekt: Gæt-et-tal spil med methods (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et gæt-et-tal spil ved brug af methods:");
            Console.WriteLine("- En method til at generere et tilfældigt tal");
            Console.WriteLine("- En method til at få brugerens gæt");
            Console.WriteLine("- En method til at sammenligne gæt med det rigtige tal");
            Console.WriteLine("- En method til at give feedback ('for højt', 'for lavt', 'rigtigt!')");
            // Lav opgaven herunder!

            static int GenerateRandomNumber(int min, int max)
            {
                return Random.Shared.Next(min, max + 1);
            }

            // Local helper: read and parse user guess; return null if user cancels
            static int? GetUserGuess(int min, int max)
            {
                Console.Write($"Gæt et tal mellem {min} og {max} (eller 'q' for at afslutte): ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return null;
                input = input.Trim();
                if (input.Equals("q", StringComparison.OrdinalIgnoreCase) ||
                    input.Equals("quit", StringComparison.OrdinalIgnoreCase)) return null;
                if (int.TryParse(input, out int guess)) return guess;
                Console.WriteLine("Ugyldigt input. Prøv igen.");
                return GetUserGuess(min, max); // re-prompt until valid or cancel
            }
            static int CompareGuess(int guess, int target)
            {
                if (guess < target) return -1;
                if (guess > target) return 1;
                return 0;
            }
            static void GiveFeedback(int comparison)
            {
                switch (comparison)
                {
                    case -1:
                        Console.WriteLine("For lavt.");
                        break;
                    case 1:
                        Console.WriteLine("For højt.");
                        break;
                    case 0:
                        Console.WriteLine("Rigtigt! Godt klaret.");
                        break;
                }
            }

            const int minValue = 1;
            const int maxValue = 100;

            while (true) // outer loop for replay
            {
                int target = GenerateRandomNumber(minValue, maxValue);
                int attempts = 0;
                Console.WriteLine($"\nJeg har valgt et tal mellem {minValue} og {maxValue}. Prøv at gætte det!");

                bool guessed = false;
                while (!guessed)
                {
                    int? maybeGuess = GetUserGuess(minValue, maxValue);
                    if (!maybeGuess.HasValue)
                    {
                        Console.WriteLine("Runden er afsluttet af brugeren.");
                        break;
                    }

                    int guess = maybeGuess.Value;
                    attempts++;

                    if (guess < minValue || guess > maxValue)
                    {
                        Console.WriteLine($"Gætte udenfor intervallet {minValue}..{maxValue}. Forsøg igen.");
                        continue;
                    }

                    int cmp = CompareGuess(guess, target);
                    GiveFeedback(cmp);

                    if (cmp == 0)
                    {
                        guessed = true;
                        Console.WriteLine($"Du brugte {attempts} forsøg.");
                    }
                }

                Console.Write("Vil du spille igen? (y/n): ");
                string? answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer) ||
                    !answer.Trim().Equals("y", StringComparison.OrdinalIgnoreCase) &&
                    !answer.Trim().Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Tak for spillet! Farvel.");
                    break;
                }
            }
        }
    }
}