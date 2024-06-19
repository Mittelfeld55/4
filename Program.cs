var blatt = "A1A2A3A4B1B2B3B4C1C2C3C4D1D2D3D4E1E2E3E4F1F2F3F4G1G2G3G4H1H2H3H4";
var anzahlKartenImBlatt = blatt.Length/ 2; 
Random rnd = new Random();
for (int i = 0; i < 30; i++)
{
var randomKarte = rnd.Next(0, anzahlKartenImBlatt - 1);
var stapelA = blatt.Substring(randomKarte*2-1);	
var stapelB = blatt.Substring(randomKarte*2+2);
blatt = stapelA + stapelB;
}
