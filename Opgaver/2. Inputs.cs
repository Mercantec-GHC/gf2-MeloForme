using System;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            string? input = Console.ReadLine();
            Console.WriteLine(input);
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal: ");
            // Lav opgaven herunder!
            int number = 9;
            Console.WriteLine(number);

        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal: ");
            // Lav opgaven herunder!
            double decimalNumber = 9.5;
            Console.WriteLine(decimalNumber);
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            // Lav opgaven herunder!
            bool isTrue = true;
            Console.WriteLine(isTrue);
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            static void PersonalProfile()
            {
                Console.WriteLine("Indtast dit navn: Aira ");
                string? Aira = Console.ReadLine();
                Console.WriteLine("Indtast din alder: 30 ");
                string? ageInput = Console.ReadLine();
                int age = int.Parse(ageInput!);
                Console.WriteLine("Indtast din hjemby: Randers ");
                string? Randers = Console.ReadLine();
                Console.WriteLine($"Hej, jeg hedder {Aira}, er {30} år gammel og kommer fra {Randers}!");
            }
        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");

            Console.WriteLine("Indtast din vægt i kg: 57 ");
            string? weightInput = Console.ReadLine();
            double weight = double.Parse(weightInput!);
            Console.WriteLine("Indtast din højde i meter: 1.64 ");
            string? heightInput = Console.ReadLine();
            double height = double.Parse(heightInput!);
            double bmi = 57 / (1.64 * 1.64);
            Console.WriteLine($"Dit BMI er: {bmi:F1}");
        }
    }
}
                