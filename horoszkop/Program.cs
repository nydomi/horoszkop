using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace horoszkop
{

    class Program
    {
        public static int asd(string a,string b)
        {
            int kk = 0;
            return kk;
        }

        static void Main(string[] args)
        {
            /*
            Vízöntő: Január 21.- Február 19.
            Halak: Február 20.-  Március 20.
            Kos: Március 21.- Április 20.
            Bika:  Április 21.- Május 21.
            Ikrek: Május 22.- Június 21.
            Rák: Június 22.- Július 22. 
            Oroszlán: Július 23.- Augusztus 23.
            Szűz: Augusztus 24.- Szeptember 22.
            Mérleg: Szeptember 23. - Október 23.
            Skorpió: Október 24.- November 22.
            Nyilas: November 23.- December 21.
            Bak: December 22.- Január 20.
            */
#region arrays and variables
            string keres;
            int ev = 2022;
            int hCount=0;
            int hNap, hNapKeres;
            string[] jegyek =  {"Bak","Vízöntő","Halak","Kos","Bika","Ikrek","Rák","Oroszlán","Szűz","Mérleg","Skorpió","Nyilas","Bak" };
            string[] honapok = { "JANUÁR", "FEBRUÁR" ,"MÁRCIUS","ÁPRILIS", "MÁJUS", "JÚNIUS"  ,"JÚLIUS"  ,"AUGUSZTUS"  ,"SZEPTEMBER"  ,"OKTÓBER" ,"NOVEMBER" ,"DECEMBER"};
#endregion

#region dates
            DateTime [] csillagNapok =
            {
                new DateTime(2021, 12, 31), 
                new DateTime(2022, 01, 20), 
                new DateTime(2022, 02, 19), 
                new DateTime(2022, 03, 21), 
                new DateTime(2022, 04, 20), 
                new DateTime(2022, 05, 21), 
                new DateTime(2022, 06, 22), 
                new DateTime(2022, 07, 23), 
                new DateTime(2022, 08, 23), 
                new DateTime(2022, 09, 23), 
                new DateTime(2022, 10, 23), 
                new DateTime(2022, 11, 22), 
                new DateTime(2022, 12, 22)
            };
#endregion

#region bekérés
            Console.Write("Irj: ");
            keres = Console.ReadLine();
            string[] temp = keres.Split(' ');
            hNapKeres =Array.IndexOf(honapok,temp[0].ToUpper())+1; // hónap
            hNap = int.Parse(temp[1]); // nap
            #endregion

            #region wtf
            try
            {
                DateTime csillagNapEredmeny = new DateTime(ev, hNapKeres, hNap);
                Console.WriteLine("Napunk:" + csillagNapEredmeny);
                for (int i = 0; i < csillagNapok.Length; i++)
                {
                    Console.WriteLine($"{csillagNapok[i]}  {csillagNapEredmeny}");
                    if (csillagNapok[i] < csillagNapEredmeny)
                    {
                        hCount = i;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hiba!");
            }
            Console.WriteLine("hCount érték: " + hCount);
            Console.WriteLine($"\nTe: {jegyek[hCount]} vagy!");
#endregion
            Console.ReadKey();
        }
    }
}
