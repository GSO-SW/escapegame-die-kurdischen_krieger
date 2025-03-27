using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    internal class Startmenue : AbstractAction
    {
        public  override void Execute()
        {
            bool running = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Willkommen zu Xatars Gold!");
                Console.WriteLine("1. Spiel starten");
                Console.WriteLine("2. Zurück");
                Console.WriteLine("3. Anleitungen");
                Console.WriteLine("4. Beenden");
                Console.Write("Bitte wähle eine Option: ");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        return;
                        break;
                    case "3":
                        ShowInstructions();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wähle 1, 2 oder 3.");
                        Console.WriteLine("Drücke eine Taste, um fortzufahren...");
                        Console.ReadKey();
                        break;
                }

                static void StartGame()
                {
                    Console.Clear();
                    Console.WriteLine("Das Spiel beginnt jetzt...");
                    Console.WriteLine("Drücke eine Taste, um zum Menü zurückzukehren...");
                    Console.ReadKey();
                }

                static void ShowInstructions()
                {
                    Console.Clear();
                    Console.WriteLine("Anleitungen:");
                    Console.WriteLine("1. Erkunde die Umgebung.");
                    Console.WriteLine("2. Löse Rätsel, um voranzukommen.");
                    Console.WriteLine("3. Finde Xatars Gold!");
                    Console.WriteLine("Drücke eine Taste, um zum Menü zurückzukehren...");
                    Console.ReadKey();
                }
            }

        }
        
    }
}
