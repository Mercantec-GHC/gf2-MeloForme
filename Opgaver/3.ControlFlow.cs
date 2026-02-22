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
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18. Indtast kun hel tal"
            );
            // Lav opgaven herunder!
            if (true)
            {
                Console.WriteLine("Indtast en værdi:");
                int value = Convert.ToInt32(Console.ReadLine());
                if (value > 18)
                {
                    Console.WriteLine("Værdien er højere end 18.");
                }
                else if (value < 18)
                {
                    Console.WriteLine("Værdien er lavere end 18.");  }
                else
                {
                    Console.WriteLine("Værdien er præcis 18.");
                }
            }

        }


        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige. Indtast kun hel tal");
            // Lav opgaven herunder!
            if (true)
            {
                Console.WriteLine("Indtast en værdi:");
                int value = Convert.ToInt32(Console.ReadLine());
                if (value % 2 == 0)
                {
                    Console.WriteLine("Værdien er lige.");  }
                else
                {
                    Console.WriteLine("Værdien er ulige.");
                }
            }

        }


        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige. Indtast kun hel tal");
            // Lav opgaven herunder!
            switch (true)
            {
                case true:
                    Console.WriteLine("Indtast en værdi:");
                    int value = Convert.ToInt32(Console.ReadLine());
                    switch (value % 2)
                    {
                        case 0:
                            Console.WriteLine("Værdien er lige.");
                            break;
                        case 1:
                            Console.WriteLine("Værdien er ulige.");
                            break;       }
                    break;
            }       }


        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine(
                "Indtast en værdi:"
            );
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value % 2)
            {
                case 0:
                    Console.WriteLine("Værdien er lige.");
                    break;
                case 1:
                    Console.WriteLine("Værdien er ulige.");
                    break;
}           }


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
            Console.WriteLine(
                "Hvad er hovedstaden i Danmark?"
            );
            string answer1 = Console.ReadLine() ?? "";
            Console.WriteLine(
                "Hvad er 2 + 2?"
            );
            string answer2 = Console.ReadLine() ?? "";
            Console.WriteLine(
                "Hvad er farven på himlen på en klar dag?"
            );
            Console.WriteLine(
                "1) Blå"
            );
            Console.WriteLine(
                "2) Grøn"
            );
            Console.WriteLine(
                "3) Rød"
            );
            string answer3 = Console.ReadLine() ?? "";
            int score = 0;
            Console.WriteLine(
                $"Dine svar: 1) {answer1}, 2) {answer2}, 3) {answer3}"
            );
            if (answer1.Trim().ToLower() == "københavn")
            {
                score++;
            }
            if (answer2.Trim() == "4")
            {
                score++;
            }
            if (answer3.Trim() == "1")
            {
                score++;
            }
            Console.WriteLine(
                $"Du fik {score} ud af 3 rigtige!"
                );
            Console.WriteLine(
                "Tak for at spille quizzen!"
            );
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3).");
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv.");
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere for en bruger og man regner gennemsnittet ud.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast en eller flere karakterer adskilt af komma, semikolon eller mellemrum (fx 12,10,7, 4, 02, 00, -3):");

            // Local helper to map a grade to feedback text
            static string GetFeedback(int grade)
            {
                switch (grade)
                {
                    case 12:
                        return "Super flot!";
                    case 10:
                        return "Meget godt!";
                    case 7:
                        return "Godt klaret!";
                    case 4:
                        return "OK, kan gøre det bedre.";
                    case 02:
                        return "Bestået - lav karakter.";
                    case 00:
                        return "Ikke bestået (00).";
                    case -3:
                        return "Ikke bestået (-3). Bedre held næste gang.";
                    default:
                        return "Ingen feedback tilgængelig.";
                }
            }

            var allowedGrades = new int[] { 12, 10, 7, 4, 02, 00, -3 };

            while (true)
            {
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ingen input modtaget. Prøv igen:");
                    continue;
                }

                var tokens = input.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var validGrades = new System.Collections.Generic.List<int>();

                foreach (var token in tokens)
                {
                    var t = token.Trim();
                    if (!int.TryParse(t, out int parsed))
                    {
                        Console.WriteLine($"Ugyldigt input '{t}' - kan ikke tolkes som tal. Springer over.");
                        continue;
                    }

                    // Map '02' and '00' are parsed as 2 and 0 respectively which is fine.
                    if (System.Array.Exists(allowedGrades, g => g == parsed))
                    {
                        validGrades.Add(parsed);
                        Console.WriteLine($"Karakter '{t}' registreret => {GetFeedback(parsed)}");
                    }
                    else
                    {
                        Console.WriteLine($"Ugyldig karakterskala '{t}'. Gyldige værdier: 12, 10, 7, 4, 02, 00, -3. Springer over.");
                    }
                }

                if (validGrades.Count == 0)
                {
                    Console.WriteLine("Ingen gyldige karakterer indtastet. Prøv igen:");
                    continue;
                }

                double average = validGrades.Average();
                Console.WriteLine($"\nDu indtastede {validGrades.Count} gyldig(e) karakter(er). Gennemsnit: {average:F2}");

                // Find nearest allowed grade to the average and give feedback for that grade
                int nearest = allowedGrades[0];
                double bestDiff = Math.Abs(average - nearest);
                foreach (var g in allowedGrades)
                {
                    double diff = Math.Abs(average - g);
                    if (diff < bestDiff)
                    {
                        bestDiff = diff;
                        nearest = g;
                    }
                }

                Console.WriteLine($"Feedback baseret på nærmeste karakter ({nearest}): {GetFeedback(nearest)}");
                break;
            }
        }
    }
}
