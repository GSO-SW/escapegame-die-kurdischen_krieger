using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    static class Spiel
    {
        public static void Spielstart()
        {
            while (true)
            {
                Console.WriteLine("Wählen Sie eine Zahl");
                Navigation.Next();
 
                Console.WriteLine($"Sie möchten in Höhle {Globals.aktuelleHoehlenNr} gehen.");
                
                Globals.aktuellerHoehle = Hoehle.alleHoehle[Globals.aktuelleHoehlenNr];
                Hoehle.alleHoehle[Globals.aktuelleHoehlenNr].HoehleBetreten();
                Hoehle.alleHoehle[Globals.aktuelleHoehlenNr].RaetselAnzeigen();
                

            }

        }
    }
}
