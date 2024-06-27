// KartenOperations.cs
using System;

public class KartenOperations
{
    public static void VerteileKarten(ref string blatt, ref int anzahlKartenImBlatt, ref string kartenDesSpielers, ref string stapelB, Random rnd)
    {
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
    }
}
