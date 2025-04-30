using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
     static class quiz
    {
        public static string frage1 = "Wann ist Xatar geboren?";
        public static string[] antworten1 = { "1969", "1979", "1981", "1987" };
        public static string richtigeAntwort1 = "1981";

        
        public static string frage2 = "Was ist Xatar?";
        public static string[] antworten2 = { "Tänzer", "Rapper", "Schauspieler", "Kurdischer Krieger" };
        public static string richtigeAntwort2 = "Rapper";

      
        public static string frage3 = "Was ist 2+2*2?";
        public static string[] antworten3 = { "8", "6", "10", "4" };
        public static string richtigeAntwort3 = "6";

        
        public static string frage4 = "Wie viele Kontinente gibt es auf der Erde?";
        public static string[] antworten4 = { "5", "6", "7", "8" };
        public static string richtigeAntwort4 = "7";

     
        public static string frage5 = "Welche Farbe entsteht, wenn man Blau und Gelb mischt?";
        public static string[] antworten5 = { "Grün", "Lila", "Orange", "Braun" };
        public static string richtigeAntwort5 = "Grün";

     
        public static string frage7 = "Was ist der groeßte Ozean der Welt ?";
        public static string[] antworten7 = { "Atlantischer Ozean", "Indischer Ozean", "Arktischer Ozean", "Pazifischer Ozean" };
        public static string richtigeAntwort7 = "Pazifischer Ozean";

        
        public static string frage8 = "Wie viele Planeten gibt es in unserem Sonnensystem?";
        public static string[] antworten8 = { "7", "8", "9", "10" };
        public static string richtigeAntwort8 = "8";

      
        public static string frage9 = "Welche Stadt ist die Hauptstadt von Deutschland?";
        public static string[] antworten9 = { "München", "Hamburg", "Berlin", "Köln" };
        public static string richtigeAntwort9 = "Berlin";

        public static string frage10 = "Was ist der hoechste Berg in Deutschland?";
        public static string[] antworten10 = { "Mount Hood", "Zugspitze", "Brocken", "Dashi Mount" };
        public static string richtigeAntwort10 = "Zugspitze";

       
        public static string frage11 = "Wann ist Xatar geboren?";
        public static string[] antworten11 = { "Hamburg", "Frankfurt", "Köln", "Stuttgart" };
        public static string richtigeAntwort11 = "Köln";

        
        public static string frage12 = "In welcher Stadt steht das beruehmte brandenburger Tor?";
        public static string[] antworten12 = { "Hamburg", "München", "Köln", "Berlin" };
        public static string richtigeAntwort12 = "Köln";

        
        public static string frage13 = "wie viele Einwohner hat Deutschland ungefähr (Stand von 2024)?";
        public static string[] antworten13 = { "69", "80", "90", "100" };
        public static string richtigeAntwort13 = "80";


        public static string frage14 = "Welche Stadt hat die kleinste Einwohnerzahl unter den deutschen Großstaedten?";
        public static string[] antworten14 = { "Bremen", "Hannover", "Dresden", "Leipzig" };
        public static string richtigeAntwort14 = "Bremen";

       
        public static string frage15 = "Welche Getraenk ist bekannt dafuer, aus teeblaettern gemacht zu werden?";
        public static string[] antworten15 = { "Kaffe", "Pipi", "Tee", "Cola" };
        public static string richtigeAntwort15 = "Tee";

   
        public static string frage16 = "Welche dieser Tiere lebt im Wasser?";
        public static string[] antworten16 = { "Hund", "Fisch", "Tiger", "Eule" };
        public static string richtigeAntwort16 = "Fisch";

       
        public static string frage17 = "Welcher Planet ist der groeßte im Sonnensystem?";
        public static string[] antworten17 = { "Venus", "Erde", "Jupiter", "Mars" };
        public static string richtigeAntwort17 = "Jupiter";

      
        public static string frage18 = "Welcher dieser Fluesse fließt durch Deutschland?";
        public static string[] antworten18 = { "Thamas", "Donau", "Nil", "Manyek" };
        public static string richtigeAntwort18 = "Donau";

        
        public static string frage19 = "Welcher dieser Berge ist der hoechste der Welt?";
        public static string[] antworten19 = { "Mount Fuji", "K2", "Mount Everest", "Mountayri" };
        public static string richtigeAntwort19 = "Mount Everest";

       
        public static string frage20 = "Wie heißt das groeßte Land der Welt?";
        public static string[] antworten20 = { "China", "USA", "Russland", "Kurdistan" };
        public static string richtigeAntwort20 = "Russland";

        public static void Quiz(string frage, string[] antworten, string richtigeAntwort)

        {

            int versuche = 0;

            const int maxVersuche = 3;

            while (versuche < maxVersuche)

            {

                Console.WriteLine(frage);

                // Antworten anzeigen

                for (int i = 0; i < antworten.Length; i++)

                {

                    Console.WriteLine($"{i + 1}. {antworten[i]}");
                    
                }

                bool antwortKorrekt = false;

                while (!antwortKorrekt)

                {

                    // Benutzereingabe abfragen

                    Console.Write("\nBitte wähle eine Antwort (1, 2, 3 oder 4): ");

                    int benutzerAntwort;

                    // Überprüfen, ob die Eingabe eine gültige Zahl ist

                    if (int.TryParse(Console.ReadLine(), out benutzerAntwort) && benutzerAntwort >= 1 && benutzerAntwort <= 4)

                    {

                        // Überprüfen, ob die Antwort korrekt ist

                        if (antworten[benutzerAntwort - 1] == richtigeAntwort)

                        {

                            Console.WriteLine("Richtig!");

                            antwortKorrekt = true;
                            break;
                        }

                        else

                        {

                            Console.WriteLine("Falsche Antwort! Versuche es noch einmal.");

                            versuche++;

                            Console.WriteLine($"Falsch! Du hast noch {maxVersuche - versuche} Versuche.");

                            if (versuche == maxVersuche)

                            {

                                Console.WriteLine("Zu viele falsche Antworten. Die richtige Antwort ist: " + richtigeAntwort);

                                Console.WriteLine("Das Spiel wird beendet.");
                                Console.WriteLine("");
                                Console.WriteLine("");

                                return; // Spiel beenden

                            }

                        }

                    }

                    else

                    {

                        Console.WriteLine("Ungültige Eingabe! Bitte wähle eine Zahl zwischen 1 und 4.");

                    }

                }

            }

        }

    }
}
