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
        public static int Next()
        {
            int naechsterHoehle = 0;
            Console.WriteLine("In welchen Raum möchtest du gehen? W = Werkstatt, T = Toilette, B = Büro, L = Lager");

            if (Console.ReadLine() == "W")
            {
                naechsterHoehle = 1;
            }
            else if (Console.ReadLine() == "T")
            {
                naechsterHoehle = 2;
            }

            else if (Console.ReadLine() == "B")
            {
                naechsterHoehle = 3;
            }

            else if (Console.ReadLine() == "L")
            {
                naechsterHoehle = 4;
            }

            else Console.WriteLine("Bitte geben Sie T, B oder L an.");

            return naechsterHoehle;
        }

    }
}
