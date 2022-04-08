using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Banka
    {
        public string jmeno_B;
        public int pocet_U;
        public string lokalita_B;
        public Ucet[] Ucty;

        public Banka(string jmeno_b, string lokalita_b, int max_pocet_u)
        {
            jmeno_B = jmeno_b;
            pocet_U = 0;
            lokalita_B = lokalita_b;
            Ucty = new Ucet[max_pocet_u];
        }

        public void Vytvor_ucet(string jmeno_U, bool stav_U, int zustatek_U, int ID_U, Vlastnik vlastnik)
        {
            if (pocet_U > Ucty.Length)
                Console.WriteLine($"Nelze vytvořit více účtů jak {Ucty.Length}!");
            else
            {
                Ucty[pocet_U] = new Ucet(jmeno_U, stav_U, zustatek_U, ID_U, vlastnik);
                pocet_U++;
            }
        }

        public void VypisInfoUctu()
        {
            foreach(Ucet ucet in Ucty)
            {
                ucet.Informace();
            }
        }
    }
}
