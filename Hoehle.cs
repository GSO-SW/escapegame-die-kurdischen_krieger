using ExitGame;
using System.Xml.Linq;

  

    public class Hoehle
    {

        //Liste, um alle Räume zu speichern
        public static List<Hoehle> alleHoehle = new List<Hoehle>();

        public int HoehlenNr;
        public bool CharackterAnw;
        public bool Zugang;
        public bool Goldspuren;
        public bool Kreaturen;
        public int[] NaechsteRaum = new int[3];
        public bool XatarsGold;


    //Berechnete Eigenschaft (Charakter anwesend oder nicht?)
    public bool CharakterAnw
        {
            get
            {
                if (Globals.aktuellerHoehle == this)
                    return true;
                return false;
            }

        }

    public Hoehle(int HoehlenNr, bool CharackterAnw, bool Zugang, bool Goldspuren, bool Kreaturen, int[] NaechsteRaum, bool XatarsGold)
                         
    
        {
            HoehlenNr = HoehlenNr;
            CharackterAnw = CharackterAnw;
            Zugang = Zugang;
            Goldspuren = Goldspuren;
            Kreaturen = Kreaturen;
            NaechsteRaum = NaechsteRaum;
            XatarsGold = XatarsGold;
            alleHoehle.Add(this);
        }

    //Statische Methode, um alle Räume zu erstellen
    public static void ErstelleHoehlen()
        {
        int[] naechsteHoehle_von1 = new int[3];
        naechsteHoehle_von1[0] = 2;

        int[] naechsteHoehle_von2 = new int[3];
        naechsteHoehle_von2[0] = 1;
        naechsteHoehle_von2[1] = 3;
        naechsteHoehle_von2[2] = 4;
        
        int[] naechsteHoehle_von3 = new int[3];
        naechsteHoehle_von3[0] = 2;

        int[] naechsteHoehle_von4 = new int[3];
        naechsteHoehle_von4[0] = 2;



        //Raum werkstatt wird erzeugt und der Liste "alleRaeume" hinzufügen
        //Werkstatt ist eine abgeleitete Klasse von Raum, s. Datei Werkstatt.cs)
            alleHoehle.Add(new Hoehle(1, true, true, false, false,naechsteHoehle_von1 , false));
            alleHoehle.Add(new Hoehle(2, true, true, false, false,naechsteHoehle_von2 , false));
            alleHoehle.Add(new Hoehle(3, true, true, true, false,naechsteHoehle_von3 , false));
            alleHoehle.Add(new Hoehle(4, true, true, false, false,naechsteHoehle_von4 , true));

            //Hier weitere Räume ergänzen und der Liste hinzufügen
        }

        //Methoden

        //Raum kann betreten werden mit dieser Methode
        public void HoehleBetreten()
        {
        Globals.aktuellerHoehle = this;
        }

        //eine virtuelle Methode, die für alle Räume speziell implementiert werden kann (s. Beispiel Werkstatt)
        public void RaetselAnzeigen(){

        if (Globals.aktuelleHoehlenNr == 1)
        {
               quiz.Quiz(quiz.frage1, quiz.antworten1, quiz.richtigeAntwort1);


        }
        else if (Globals.aktuelleHoehlenNr == 2)
        {
            quiz.Quiz(quiz.frage2, quiz.antworten2, quiz.richtigeAntwort2);

        }
        else if(Globals.aktuelleHoehlenNr == 3)
        {
            Console.WriteLine("Du bist in Höhle 3.");
            quiz.Quiz(quiz.frage8, quiz.antworten8, quiz.richtigeAntwort8);

        }
        else if (Globals.aktuelleHoehlenNr == 4)
        {
            quiz.Quiz(quiz.frage16, quiz.antworten16, quiz.richtigeAntwort16);

        }
    }



    }


