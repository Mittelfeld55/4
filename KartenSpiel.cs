using System;

class Kartenspiel
{
    public void SpielStarten()
    {
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
            Console.WriteLine("\nWelche Karte brauchst? (z.B. A1)");
            var benoetigteKarte = (Console.ReadLine()?.Trim().ToUpper() ?? "").Substring(0, 2);

            if (string.IsNullOrEmpty(benoetigteKarte) || benoetigteKarte.Length != 2)
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
                    string gezogeneKarte = KartenOperations.ZieheKarte(ref blatt, ref anzahlKartenImBlatt, rnd);
                    kartenDesSpielers += gezogeneKarte;

                    Console.WriteLine("Der Computer hat " + gezogeneKarte + " gezogen.");
                    stapelB += gezogeneKarte;
                    Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length / 2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length / 2);
                }
            }
        }

        // End of game logic
    }
}
    