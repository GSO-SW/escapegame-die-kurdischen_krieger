using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    static class Navigation
    {
        //Methode zur Navigation, in welchen Raum die Person als nächstes gehen will
        public static void Next()
        {
            int naechsterHoehle = 0;
            Console.WriteLine("In welche Hohle möchtest du gehen? 1 = Höhle1, 2 = Höhle2, 3 = Höhle3, 4 = Höhle4");
            string antwort = Console.ReadLine();

            if (antwort == "1")
            {
                Globals.aktuelleHoehlenNr = 1;
                
            }
            else if (antwort == "2")
            {
                Globals.aktuelleHoehlenNr = 2;
                
            }

            else if (antwort == "3")
            {
                Globals.aktuelleHoehlenNr = 3;
            }

            else if (antwort == "4")
            {
                Globals.aktuelleHoehlenNr = 4;
            }

            else Console.WriteLine("Bitte geben Sie 1, 2, 3 oder 4 an.");

    
        }

    }
}
