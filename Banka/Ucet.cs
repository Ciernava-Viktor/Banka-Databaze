using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Ucet
    {
        public string jmeno_U;
        public bool stav_U;
        public int zustatek_U;
        public int ID_U;
        public Vlastnik Vlastnik;

        public Ucet(string jmeno_u, bool stav_u, int zustatek_u, int id_u, Vlastnik vlastnik)
        {
            jmeno_U = jmeno_u;
            stav_U = stav_u;
            zustatek_U = zustatek_u;
            ID_U = id_u;
            Vlastnik = vlastnik;
        }

        public void Informace()
        {
            Console.WriteLine($"ID: {ID_U}    Název: {jmeno_U}    Stav: {stav_U}    Zustatek: {zustatek_U}    Vlastník: {Vlastnik.jmeno_V} {Vlastnik.prijmeni_V}");
        }
    }
}
