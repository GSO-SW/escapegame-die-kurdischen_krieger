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
        public static int Next()
        {
            int naechsterHoehle = 0;
            Console.WriteLine("In welche Hohle möchtest du gehen? 1 = Höhle1, 2 = Höhle2, 3 = Höhle3, 4 = Höhle4");

            if (Console.ReadLine() == "1")
            {
                naechsterHoehle = 1;
            }
            else if (Console.ReadLine() == "2")
            {
                naechsterHoehle = 2;
            }

            else if (Console.ReadLine() == "3")
            {
                naechsterHoehle = 3;
            }

            else if (Console.ReadLine() == "4")
            {
                naechsterHoehle = 4;
            }

            else Console.WriteLine("Bitte geben Sie 1, 2, 3 oder 4 an.");

            return naechsterHoehle;
        }

    }
}
