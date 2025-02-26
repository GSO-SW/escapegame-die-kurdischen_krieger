using System;
public class Program
{
    public static void Main()
    {
        Hoehle Hoehle1 = new Hoehle ();
        Hoehle1.HoehlenNr = 1;
        Hoehle1.CharackterAnw = true;
        Hoehle1.Zugang = true;
        Hoehle1.Goldspuren = false;
        Hoehle1.Kreaturen = false;
        Hoehle1.NaechsteRaum[0] = 2;
        Hoehle1.XatarsGold = false;
        
        Hoehle Hoehle2 = new Hoehle ();
        Hoehle2.HoehlenNr = 2;
        Hoehle2.CharackterAnw = true;
        Hoehle2.Zugang = true;
        Hoehle2.Goldspuren = false;
        Hoehle2.Kreaturen = false;
        Hoehle2.NaechsteRaum[0]=1;
        Hoehle2.NaechsteRaum[1]=3;
        Hoehle2.NaechsteRaum[2]=4;
        Hoehle2.XatarsGold = false;
        
        Hoehle Hoehle3 = new Hoehle ();
        Hoehle3.HoehlenNr = 3;
        Hoehle3.CharackterAnw = true;
        Hoehle3.Zugang = true;
        Hoehle3.Goldspuren = true;
        Hoehle3.Kreaturen = false;
        Hoehle3.NaechsteRaum[0] = 2;
        Hoehle3.XatarsGold = false;
        
        Hoehle Hoehle4 = new Hoehle ();
        Hoehle4.HoehlenNr = 4;
        Hoehle4.CharackterAnw = true;
        Hoehle4.Zugang = true;
        Hoehle4.Goldspuren = false;
        Hoehle4.Kreaturen = false;
        Hoehle4.NaechsteRaum[0] = 2;
        Hoehle4.XatarsGold = true;
    }
    }
