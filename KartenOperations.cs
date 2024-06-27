using System;

class KartenOperations
{
    public static void VerteileKarten(ref string blatt, ref int anzahlKartenImBlatt, ref string kartenDesSpielers, ref string stapelB, Random rnd)
    {
        for (int i = 0; i < 14; i++)
        {
            var randomKarte = rnd.Next(0, anzahlKartenImBlatt);
            int startIndex = randomKarte * 2;

            if (startIndex < blatt.Length - 1)
            {
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
            else
            {
                Console.WriteLine("Error: startIndex is out of bounds.");
            }
        }
    }

    public static string ZieheKarte(ref string blatt, ref int anzahlKartenImBlatt, Random rnd)
    {
        int Karteziehen = rnd.Next(0, anzahlKartenImBlatt);
        int startIndex = Karteziehen * 2;

        if (startIndex < blatt.Length - 1)
        {
            string gezogeneKartekarte = blatt.Substring(startIndex, 2);
            blatt = blatt.Remove(startIndex, 2);
            return gezogeneKartekarte;
        }
        else
        {
            Console.WriteLine("Error: startIndex is out of bounds.");
            return ""; // Return empty string or handle error case appropriately
        }
    }
}
