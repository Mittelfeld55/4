
using System;

class Kartenspiel
{
    public void SpielStarten()
    {
        #pragma warning disable CS0219 // Unterdrückt die Warnung für ungenutzte Variablen
        
        var blatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
        Console.WriteLine("Blatt: " + blatt + " " + blatt.Length / 2);
        int anzahlKartenImBlatt = blatt.Length / 2;
        string kartenDesSpielers = "";
        string stapelB = "";
        Random rnd = new Random();

        // Use the method from the separate class file
        KartenOperations.VerteileKarten(ref blatt, ref anzahlKartenImBlatt, ref kartenDesSpielers, ref stapelB, rnd);

        Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length / 2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length / 2);

        // Nach Karten Fragen
        int y = 15;
        for (int i = 0; i < y; i++)
        {
            Console.WriteLine("\nWelche Karte brauchst? (z.B. A1)	");
            var benoetigteKarte = (Console.ReadLine()?.Trim().ToUpper() ?? " ").Substring(0, 2);
            if (benoetigteKarte == " " || benoetigteKarte.Length > 2)
            {
                Console.WriteLine(" Error! Du hast keine oder mehr als 2 Karten eingegeben.");
            }
            else
            {
                if (stapelB.Contains(benoetigteKarte))
                {
                    Console.WriteLine("Der Gegner hat die Karte " + benoetigteKarte);
                    stapelB = stapelB.Replace(benoetigteKarte, "");
                    kartenDesSpielers += benoetigteKarte;
                    Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length / 2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length / 2);
                }
                else
                {
                    Console.WriteLine("Der Gegner hat die Karte " + benoetigteKarte + " nicht.");
                    var Karteziehen = rnd.Next(0, anzahlKartenImBlatt);
                    int startIndex = Karteziehen * 2;
                    string gezogeneKartekarte = blatt.Substring(startIndex, 2);
                    Console.WriteLine("Du hast die Karte " + gezogeneKartekarte + " gezogen.");
                    blatt = blatt.Remove(startIndex, 2);
                    kartenDesSpielers += gezogeneKartekarte;
                }
                string zieheBlatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
                string SubstringToRemove = stapelB;
                var zieheBlattLength = zieheBlatt.Length / 2;
                var nachKarteFragen = rnd.Next(0, zieheBlattLength);
                int angefragteKarte = nachKarteFragen * 2;
                string gefragteKarte = blatt.Substring(angefragteKarte, 2);
                Console.WriteLine("\nDer Computer hat nach: " + gefragteKarte + " gefragt.");
                if (kartenDesSpielers.Contains(gefragteKarte))
                {
                    Console.WriteLine("Du hattest die Karte " + gefragteKarte);
                    kartenDesSpielers = kartenDesSpielers.Replace(gefragteKarte, " ");
                    Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length / 2);
                    Console.WriteLine("|      Karten des Gegners: " + stapelB + " " + stapelB.Length / 2);
                }
                else
                {
                    Console.WriteLine("\nDu hast die Karte " + gefragteKarte + " nicht.");
                    var Karteziehen = rnd.Next(0, anzahlKartenImBlatt);
                    int startIndex = Karteziehen * 2;
                    string gezogeneKartekarte = blatt.Substring(startIndex, 2);
                    Console.WriteLine("Der Computer hat " + gezogeneKartekarte + " gezogen.");
                    blatt = blatt.Remove(startIndex, 2);
                    stapelB += gezogeneKartekarte;
                    Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length / 2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length / 2);
                }
            }
        }
        
        #pragma warning restore CS0219 // Hebt die Unterdrückung der Warnung auf
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kartenspiel spiel = new Kartenspiel();
        spiel.SpielStarten();
    }
}
