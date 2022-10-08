using System;
using System.Collections.Generic;
using System.IO;
using balkezesek.models;
using System.Linq;


namespace balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jatekos> balkezesek = new List<Jatekos>();

            #region 2. feladat
            using (var sr = new StreamReader("balkezesek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    balkezesek.Add(new Jatekos(sor));
                }
            }

            #endregion

            #region 3. feladat
            Console.WriteLine("3. feladat" + " "+ balkezesek.Count);
            #endregion

            #region 4. feladat
            Console.WriteLine("4. feladat");
            var oktoberi99 = balkezesek.Where(x => x.UtolsoPalyaraLepes.Year == 1999 && x.UtolsoPalyaraLepes.Month == 10).ToList();
            oktoberi99.ForEach(x => Console.WriteLine($"{x.Name}, {Math.Round(x.Magassag*2.54, 1)} cm"));
            Console.WriteLine();
            #endregion

            #region 5. feladat
            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérek egy évszámot 1990 és 1999 közötti évszámot!: ");
            int evszam = 0;
            do
            {
                var input = Console.ReadLine();
                int.TryParse(input, out evszam);
                if (evszam >= 1990 && evszam <= 1999) { break;}
                Console.WriteLine("Hibás adat, kérek egy évszámot 1990 és 1999 közötti évszámot!: ");
            } while (evszam < 1990 || evszam > 1999);
            #endregion

            #region 6. feladat
            var atlagsuly = balkezesek.Where(x => x.ElsoPalyaraLepes.Year <= evszam && x.UtolsoPalyaraLepes.Year >= evszam).Average(x => x.Suly);
            Console.WriteLine("6. feladat " + Math.Round(atlagsuly, 2) + " font");
            #endregion
            Console.ReadKey();
        }
    }
}
