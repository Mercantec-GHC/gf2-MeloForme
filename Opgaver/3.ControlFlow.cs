using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            static void IfExample()
            {
                Console.Write("Indtast din alder: ");
                string input = Console.ReadLine();
                int alder;
                // Prøv at konvertere input til et heltal
                bool success = int.TryParse(input, out alder);
                if (!success)
                {
                    Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
                    return;
                }
                if (alder < 18)
                {
                    Console.WriteLine("Du er under 18 år gammel.");
                }
                else if (alder == 18)
                {
                    Console.WriteLine("Du er præcis 18 år gammel.");
                }
                else
                {
                    Console.WriteLine("Du er over 18 år gammel.");
                }
            }
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            static void IfExample()
            {
                Console.Write("Indtast et tal: ");
                string input = Console.ReadLine();
                int tal;
                // Prøv at konvertere input til et heltal
                bool success = int.TryParse(input, out tal);
                if (!success)
                {
                    Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
                    return;
                }
                if (tal % 2 == 0)
                {
                    Console.WriteLine("Tallet er lige.");
                }
                else
                {
                    Console.WriteLine("Tallet er ulige.");
                }
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            static void SwitchExample()
            {
                Console.Write("Indtast et tal mellem 1 og 5: ");
                string input = Console.ReadLine();
                int tal;
                // Prøv at konvertere input til et heltal
                bool success = int.TryParse(input, out tal);
                if (!success)
                {
                    Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
                    return;
                }
                switch (tal)
                {
                    case 1:
                        Console.WriteLine("Du indtastede et.");
                        break;
                    case 2:
                        Console.WriteLine("Du indtastede to.");
                        break;
                    case 3:
                        Console.WriteLine("Du indtastede tre.");
                        break;
                    case 4:
                        Console.WriteLine("Du indtastede fire.");
                        break;
                    case 5:
                        Console.WriteLine("Du indtastede fem.");
                        break;
                    default:
                        Console.WriteLine("Tallet er uden for intervallet 1-5.");
                        break;
                }
            }
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            static void TernaryExample()
            {
                Console.Write("Indtast et tal: ");
                string input = Console.ReadLine();
                int tal;
                // Prøv at konvertere input til et heltal
                bool success = int.TryParse(input, out tal);
                if (!success)
                {
                    Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
                    return;
                }
                string resultat = (tal % 2 == 0) ? "Tallet er lige." : "Tallet er ulige.";
                Console.WriteLine(resultat);
            }
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!

        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
        }
    }
}
