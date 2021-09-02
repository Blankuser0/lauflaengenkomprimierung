using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lauflaengenkomprimierung
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl = 0;
            int index = 0;
            int i = 0;
            string Bilddaten = "QQQQRRRRRRTTTTTTTTTTLLLLLLLLLLLMNNNVVVVVVVVVVVAAAAAAAAAAAAA";
            string KomprimierteDaten = "";

            while (index < Bilddaten.Length)
            {
                anzahl = 0;
                i = index;

                while ((i < Bilddaten.Length) && (Bilddaten[i] == Bilddaten[index]))
                {
                    anzahl = anzahl + 1;
                    i = i + 1;
                }

                if(anzahl > 3)
                {
                    KomprimierteDaten = KomprimierteDaten + "§" + anzahl.ToString() + Bilddaten[index];
                    index = index + anzahl;
                }
                else
                {
                    KomprimierteDaten = KomprimierteDaten + Bilddaten[index];
                    index = index + 1;
                }  
            }

            System.Console.WriteLine(KomprimierteDaten);
        }
    }
}
