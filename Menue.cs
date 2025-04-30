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
            bool wiederholen = true;
            
            while(wiederholen)
            {   
                Console.WriteLine("Herzlich Willkommen zum Spiel finde Xatars Gold. Bitte wählen Sie eine Option:");
                Console.WriteLine("1. Spiel beginnen");
                Console.WriteLine("2. Beenden");

                string auswahl = Console.ReadLine();

                if (auswahl == "1")
                {
                    wiederholen = false;
                    Spiel.Spielstart();

                }
                
                else if (auswahl == "2")
                {
                    Console.WriteLine("Das Spiel wird beendet.");
                    Environment.Exit(0);
                }
                

                
            } 
        }
    }
}
