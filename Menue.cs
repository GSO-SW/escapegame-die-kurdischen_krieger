using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    static class Menue
    {
        public static void MenueAnzeigen()
        {
            while (true)
            {
                Console.WriteLine("Herzlich Willkommen zum Spiel finde Xatars Gold. Bitte wählen Sie eine Option:");
                Console.WriteLine("1. Spiel beginnen");
                Console.WriteLine("2. Beenden");

                string auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        Spiel.Spielstart();

                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                        break;
                }
            }
        }
    }
}
