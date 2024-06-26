var blatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
Console.WriteLine("Blatt: " + blatt + " " + blatt.Length/2);
int anzahlKartenImBlatt = blatt.Length / 2;
string kartenDesSpielers = "";
string stapelB = "";
Random rnd = new Random();

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

var kartenAufDemStapel = blatt;
Console.Write("\nDeine Karten : " + kartenDesSpielers + " " + kartenDesSpielers.Length/2);
Console.WriteLine("|      Karten des Gegners: " + stapelB + " " + stapelB.Length/2);
// Console.WriteLine("Karten, die auf dem Stapel sind: " + kartenAufDemStapel + " " + kartenAufDemStapel.Length/2);
