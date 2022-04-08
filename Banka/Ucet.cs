using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Ucet
    {
        public string jmeno_U { get; private set; }
        public bool stav_U { get; private set; }
        public int zustatek_U { get; private set; }
        public int ID_U { get; private set; }
        public Vlastnik Vlastnik { get; private set; }

        public Ucet(string jmeno_u, bool stav_u, int zustatek_u, int id_u, Vlastnik vlastnik)
        {
            jmeno_U = jmeno_u;
            stav_U = stav_u;
            zustatek_U = zustatek_u;
            ID_U = id_u;
            Vlastnik = vlastnik;
        }

        public string setVlastnik(Vlastnik vlastnik)
        {
            Vlastnik = vlastnik;
            return $"{Vlastnik.jmeno_V} {Vlastnik.prijmeni_V}";
        }

        public void Informace()
        {
            Console.WriteLine(
                !(Vlastnik is null)
                    ? $"ID: {ID_U}    Název: {jmeno_U}    Stav: {stav_U}    Zustatek: {zustatek_U}    Vlastník: {Vlastnik.jmeno_V} {Vlastnik.prijmeni_V}"
                    : $"ID: {ID_U}    Název: {jmeno_U}    Stav: {stav_U}    Zustatek: {zustatek_U}    Vlastník: Nemá vlastníka"
            );
        }
    }
}
