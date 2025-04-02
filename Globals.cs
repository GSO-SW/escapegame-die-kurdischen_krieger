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
                Console.WriteLine("test");
                int naechsterHoehle = Navigation.Next() - 1;
                Globals.aktuellerHoehle = Hoehle.alleHoehle[naechsterHoehle];
                Hoehle.alleHoehle[naechsterHoehle].HoehleBetreten();
                Hoehle.alleHoehle[naechsterHoehle].RaetselAnzeigen();

            }

        }
    }
}
