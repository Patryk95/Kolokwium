using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    interface IPrzychodnia
    {
      //  void UstawLekarz(string imieN, string Specjalnosc);
        void DodajDoKolejki(string imieN, int wiek, string choroba);
        string WykonajPorade();
        string WykonajBadanie();
       // int CzasOczekiwania();
      //  void Generujraport();
    }
}
