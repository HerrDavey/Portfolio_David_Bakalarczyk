using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logika_prezentacja
{
    class Zadanie
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int Priorytet { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} ", Nazwa, Opis, Priorytet);
        }
    }
}
