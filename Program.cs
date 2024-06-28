#pragma warning disable CS0219
var blatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
Console.WriteLine("Blatt: " + blatt + " " + blatt.Length/2);
Random rnd = new Random();
int anzahlKartenImBlatt = blatt.Length / 2;
string kartenDesSpielers = "";
string stapelB = "";
var pPunkte = 0; 
var cPunkte = 0;
bool sZ = true;
bool cZ;

//Karten verteilen
for (int i = 0; i < 14; i++)
{
    var randomKarte = rnd.Next(0, anzahlKartenImBlatt);
    int startIndex = randomKarte * 2;
    string karte = blatt.Substring(startIndex, 2);
    blatt = blatt.Remove(startIndex, 2);
    anzahlKartenImBlatt--;
    if (i % 2 == 0)
    {
        kartenDesSpielers += karte;
    }
    else
    {
        stapelB += karte;
    }
}
Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length/2);

//Nach Karten Fragenx
int y = 15;
for (int i = 0; i < y; i++)
{
    if (sZ & !cZ) { //Spieler Zug
        Console.WriteLine("\nWelche Karte brauchst? (z.B. A1)	");
        var benoetigteKarte = (Console.ReadLine()?.Trim().ToUpper() ?? " ").Substring(0, 2);
        if (benoetigteKarte == " " || benoetigteKarte.Length > 2) 
        {
            Console.WriteLine(" Error! Du hast keine oder 2 Karten eingegeben.");   
        }
        else
        {
            if (stapelB.Contains(benoetigteKarte))
            {
                stapelB = stapelB.Replace(benoetigteKarte, "");
                kartenDesSpielers += benoetigteKarte;
                Console.Write("Der Gegner hat die Karte " + benoetigteKarte + "\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length/2);
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
        }
<<<<<<< HEAD
        cZ = !cZ;
        sZ = !sZ;
=======
        cZ = true;
        sZ = false;
        // test commit
>>>>>>> 22c77a49376575af7fa88e64140ab717b20ee8f8
    }
    else if (cZ & !sZ) { //Gegner Zug
        string zieheBlatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
        string SubstringToRemove = stapelB;
        var zieheBlattLength = zieheBlatt.Length / 2;
        var nachKarteFragen = rnd.Next(0, zieheBlattLength);
        int angefragteKarte = nachKarteFragen * 2;
        string gefragteKarte = blatt.Substring(angefragteKarte, 2);
        Console.WriteLine("\nDer Computer hat nach: " + gefragteKarte + " gefragt.");
        if (kartenDesSpielers.Contains(gefragteKarte)) 
        {
            kartenDesSpielers = kartenDesSpielers.Replace(gefragteKarte, " ");
            Console.WriteLine("Du hattest die Karte " + gefragteKarte +  "\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length/2);
        }
        else 
        {
            var Karteziehen = rnd.Next(0, anzahlKartenImBlatt);
            int startIndex = Karteziehen * 2;
            string gezogeneKartekarte = blatt.Substring(startIndex, 2);
            blatt = blatt.Remove(startIndex, 2);
            stapelB += gezogeneKartekarte;
            Console.Write("\nDu hast die Karte " + gefragteKarte + " nicht. \nDer Computer hat " + gezogeneKartekarte + " gezogen.\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + stapelB + " " + stapelB.Length/2);
        }
        cZ = !cZ;
        sZ = !sZ;
    }
    else
    {
        return;
    } 
}