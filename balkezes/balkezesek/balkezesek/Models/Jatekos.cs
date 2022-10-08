using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek.models
{
    public class Jatekos
    {
        
        public String Name { get; set; }
        public DateTime ElsoPalyaraLepes { get; set; }
        public DateTime UtolsoPalyaraLepes { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Jatekos(string[] sor)
        {
            Name = sor[0];
            ElsoPalyaraLepes = Convert.ToDateTime(sor[1]);
            UtolsoPalyaraLepes = Convert.ToDateTime(sor[2]);
            Suly = Convert.ToInt32(sor[3]);
            Magassag = Convert.ToInt32(sor[4]);
        }

        public Jatekos(string name, DateTime elsoPalyaraLepes, DateTime utolsoPalyaraLepes, int suly, int magassag)
        {
            Name = name;
            ElsoPalyaraLepes = elsoPalyaraLepes;
            UtolsoPalyaraLepes = utolsoPalyaraLepes;
            Suly = suly;
            Magassag = magassag;
        }
    }
}
