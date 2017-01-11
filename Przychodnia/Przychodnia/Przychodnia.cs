using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Przychodnia : IPrzychodnia 
    {
        private List<Lekarz> lekarz = new List<Lekarz>(); //////
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();
      /*  public void UstawLekarza(string imieN, string specjalnosc)
        {
            this.lekarz = lekarz;
            // lekarz.Add(new Lekarz(imieN,specjalnosc));
        }*/
        public void DodajDoKolejki(string imieN, int wiek, string choroba)
        {
            pacjenci.Equals(new Pacjent(imieN, wiek, choroba));
        }
        public string WykonajPorade()
        {
            Pacjent pacjent = pacjenci.Dequeue();
            if (pacjenci.Count > 0)
            {
                pacjenci.Dequeue();
            }



            return "Wykonano Porade" + pacjenci;


        }
        public string WykonajBadanie()
        {
            Pacjent pacjent = pacjenci.Peek();
            if (pacjenci.Count > 0)
            {
                pacjenci.Peek();
            }
            return "Wykonano badanie" + pacjenci;
        }
            public int CzasOczekiwania()
        {
            int ilosc = 0;
                  foreach (var e in pacjenci)
                  {
                      ilosc++;
                  }
                  return ilosc/2;
        }
           public bool Czylekarz()
            {
            if (lekarz  != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            }
    }
}

