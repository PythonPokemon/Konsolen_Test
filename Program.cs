using System;
using System.Security.Cryptography.X509Certificates;

namespace Konsolen_Test
{
    public class Program
    {
        // Member variablen sind innerhalb der klasse, aber nicht in der methode!
        
        
        // Konstante - Member
        //const double PI = 3.14159265359;
        //const int wochen = 52, monate = 12;
        //const string geburtstag = "07.10.1990";

        // Startpunkt des Programmes | Hauptmethode
        static void Main(string[] args)
        {   //----------------------------------------------------------------------------------------------------------------------- Parsing
            /* zum testen auskommentieren | also umwandung eines primitiven datentypes in einen anderen primitiven datentyp */

            //string ersterString = "15";
            //string zweiterString = "20";

            //int nummer1 = int.Parse(ersterString);
            //int nummer2 = int.Parse(zweiterString);

            //int ergebnis = nummer1 + nummer2;

            //Console.WriteLine(ergebnis);

            //----------------------------------------------------------------------------------------------------------------------- Konstanten
            // Konstanten müssen nach der deklaration initialisiert werden | also: const double PI; geht nicht! sondern: const double PI = 3.14159265359;
            // können nach der initialisierung nicht mehr verändert werden!
            // und wenn man auf Klassen Member ausßerhalb der methode zugreifen möchte muss man diese member erst 'static' machen!
            // oder eine konstante sein!
            //Console.WriteLine(PI);
            //Console.WriteLine(wochen);
            //Console.WriteLine(monate);                       
            //Console.WriteLine("Mein Geburtstag ist am: " + geburtstag);

            //----------------------------------------------------------------------------------------------------------------------- Methoden
            // syntax: zugriffsmodofizierer static rückgabetyp/void name (parameter1, parameter2, optional){methodenkörper};

            // Aufruf einer separaten Methode aus der Hauptmethode
            methoden_Name();
            methode_Mit_Parametern("hier wird nun ein string erwartet, da in der separaten methode das so übergeben wurde!");
        }

        // Separate Methode | ohne rückgabewert & ohne parameterliste
        public static void methoden_Name()
        {
            Console.WriteLine("Separate Methode");
            Console.ReadKey();
        }

        // separate methode mit parametern
        public static void methode_Mit_Parametern(string meinText)
        {
            Console.WriteLine(meinText);
        }

    }
}
