using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    // Koliko je ukupno elemenata u nizu?
    // Koliko je elemenata niza u mjesecu srpnju?
    // Koliko elemenata niza ima zapis s 7 sekundi?
    // Koja je prosječna vrijednost svih zapisa za minute?
    // U kojim sve godinama postoje zapisi?
    // Koliko je zapisa koji se mogu pojaviti samo u prijestupnim godinama?
    // Koliko je zapisa čije je vrijeme između 4 i 5 sati u noći?
    public class PodaciDateTime
    {

        public static DateTime[] Niz()
        {

            DateTime[] niz = new DateTime[Podaci.Length];
            for (int i = 0; i < Podaci.Length; i++)
            {
                niz[i] = DateTime.Parse(Podaci[i]);
            }
            return niz; 

        }
        private static String[] Podaci = {
        "2024-04-30 03:43:36",
"2024-01-23 19:24:01",
"2024-06-27 23:01:49",
"2024-12-14 21:49:10",
"2024-12-13 19:01:57",
"2024-02-27 08:21:54",
"2024-05-26 03:46:14",
"2024-01-16 18:13:13",
"2024-06-13 22:30:53",
"2024-09-28 03:37:13",
"2024-09-30 05:57:55",
"2024-10-13 01:08:57",
"2024-08-30 00:36:58",
"2024-05-03 23:46:40",
"2024-03-23 18:37:59",
"2024-09-13 12:07:59",
"2024-11-03 05:26:24",
"2024-04-02 17:18:55",
"2024-11-24 23:19:18",
"2024-03-20 00:08:42",
"2024-03-16 09:24:31",
"2024-11-05 21:43:01",
"2024-11-24 18:59:04"
        };


    }
}
