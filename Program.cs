#pragma warning disable CS0219
var blatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
Random rnd = new Random();
int anzahlKartenImBlatt = blatt.Length / 2;
string kartenDesSpielers = "";
string kartenDesGegners = "";
var pPunkte = 0; 
var cPunkte = 0;
bool sZ = true;
bool cZ = false;
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
        kartenDesGegners += karte;
    }
}
Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + kartenDesGegners + " " + kartenDesGegners.Length/2);

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
            if (kartenDesGegners.Contains(benoetigteKarte))
            {
                kartenDesGegners = kartenDesGegners.Replace(benoetigteKarte, "");
                kartenDesSpielers += benoetigteKarte;
                Console.Write("Der Gegner hat die Karte " + benoetigteKarte + "\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + kartenDesGegners + " " + kartenDesGegners.Length/2);
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
        cZ = !cZ; sZ = !sZ;
    }
    else if (cZ & !sZ) { //Gegner Zug
        string zieheBlatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
        string SubstringToRemove = kartenDesGegners;
        var zieheBlattLength = zieheBlatt.Length / 2;
        var nachKarteFragen = rnd.Next(0, zieheBlattLength);
        int angefragteKarte = nachKarteFragen * 2;
        string gefragteKarte = blatt.Substring(angefragteKarte, 2);
        Console.WriteLine("\nDer Computer hat nach: " + gefragteKarte + " gefragt.");
        if (kartenDesSpielers.Contains(gefragteKarte)) 
        {
            kartenDesSpielers = kartenDesSpielers.Replace(gefragteKarte, " ");
            Console.WriteLine("Du hattest die Karte " + gefragteKarte +  "\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + kartenDesGegners + " " + kartenDesGegners.Length/2);
        }
        else 
        {
            var Karteziehen = rnd.Next(0, anzahlKartenImBlatt);
            int startIndex = Karteziehen * 2;
            string gezogeneKartekarte = blatt.Substring(startIndex, 2);
            blatt = blatt.Remove(startIndex, 2);
            kartenDesGegners += gezogeneKartekarte;
            Console.Write("\nDu hast die Karte " + gefragteKarte + " nicht. \nDer Computer hat " + gezogeneKartekarte + " gezogen.\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2 + " |      Karten des Gegners: " + kartenDesGegners + " " + kartenDesGegners.Length/2);
        }
        cZ = !cZ;
        sZ = !sZ;
    }
    string[] kartenA = { "A1", "A2", "A3", "A4" };
    string[] kartenB = { "B1", "B2", "B3", "B4" };
    string[] kartenC = { "C1", "C2", "C3", "C4" };
    string[] kartenD = { "D1", "D2", "D3", "D4" };
    string[] kartenE = { "E1", "E2", "E3", "E4" };
    string[] kartenF = { "F1", "F2", "F3", "F4" };
    

if  (
    kartenA.All(k => kartenDesSpielers.Contains(k))
    ) 
{
    pPunkte++;
    foreach (var karte in kartenA)
    {
        kartenDesSpielers = kartenDesSpielers.Replace(karte, " ");
    }
}

}