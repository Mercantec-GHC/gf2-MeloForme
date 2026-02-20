using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            //String1();
            //Int1();
            //Double1();
            //Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine();
            // Lav opgaven herunder!        
            Console.WriteLine("Hvad hedder du?");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hej {name}, hold da op :O sikke et smukt navn ;)!");
        }

        public static void Int1()
        {
            Console.WriteLine();
            // Lav opgaven herunder!
            int number;
            Console.Write("Hvor gammel er du? ");
            string? input = Console.ReadLine();
            number = int.Parse(input!);
            Console.WriteLine($"{number} år, hold da op :O du holder dig godt :D!");
        }

        public static void Double1()
        {
            Console.WriteLine();
            // Lav opgaven herunder!
            double number;
            Console.Write("Hvor høj er du i meter? ");
            string? input = Console.ReadLine();
            number = double.Parse(input!);
            Console.WriteLine($"Du er {number} meter høj :O Det er sexy høj :)!");
        }

        public static void Bool1()
        {
            Console.WriteLine();
            
            Console.Write("Is it true or false, that the capital of Denmark is Copehagen?");
            string? input = Console.ReadLine();
            bool sandt;
            if (input is null)
            {
                Console.WriteLine("Intet input modtaget. Antager 'falsk'.");
                sandt = false;
            }
            else
            {
                string norm = input.Trim().ToLowerInvariant();
                if (norm == "sandt" || norm == "ja" || norm == "true")
                    sandt = true;
                else if (norm == "falsk" || norm == "nej" || norm == "false")
                    sandt = false;
                else if (!bool.TryParse(norm, out sandt))
                {
                    Console.WriteLine("Ugyldigt svar. Brug 'sandt' eller 'falsk'. Antager 'falsk'.");
                    sandt = false;
                }
            }
            Console.WriteLine($"That is exactly {true} :D You are so smart 8)!");
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
            Console.WriteLine("Hvad hedder du?");
            string? NavnInput = Console.ReadLine();
            Console.WriteLine("Hvor gammel er du?");
            string? AlderInput = Console.ReadLine();
            Console.WriteLine("Til sidst hvor bor du?");
            string? ByInput = Console.ReadLine();
            Console.WriteLine(@"Hej, jeg hedder " 
                + NavnInput + ", er " 
                + AlderInput + " år gammel og kommer fra " 
                + ByInput + "! ");
            Console.WriteLine(@$"Wow, det var da en interressant navn du har {NavnInput} :O 
            Du ser da også godt ud i din alder på {AlderInput} år ;) 
            Det er da også en spændende by at bo i {ByInput} :D!");
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

            // ------------------------------------------
            Console.WriteLine("Indtast din vægt i kg. Skriv kun et helt tal: ");
            string? weightInput = Console.ReadLine();
            double weight = double.Parse(weightInput!);
            Console.WriteLine("Indtast din højde i meter. Skriv det i decimal tal, brug komma: ");
            string? heightInput = Console.ReadLine();
            double height = double.Parse(heightInput!);
            double bmi = weight / (height * height);
            Console.WriteLine($"Du vejer " + weight + " kg og er " + height + " meter høj. Dit BMI er: " + bmi);
        }
    }
}
                