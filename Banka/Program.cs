using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka CS = new Banka("Česká Spořitelna", "Okružní 920", 15);

            Vlastnik vlastnik = new Vlastnik("Pepa", "Mladý", 10, "010212/5547");

            List<Vlastnik> vlastnici = new List<Vlastnik>();
            vlastnici.Add(vlastnik);

            for(int i = 0; i < 15; i++)
            {
                CS.Vytvor_ucet("Účet" + i, true, 100, i, null);
            }
            
            CS.Priradit_Vlastnika(10, vlastnici);

            CS.VypisInfoUctu();
            Console.ReadLine();
        }
    }
}
