using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacjaProdukt
{
    class Produkt
    {
        private string symbol;
        private string nazwa;
        private int liczbaSztuk;
        private string magazyn;

        public string Symbol { get => symbol; set => symbol = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int LiczbaSztuk { get => liczbaSztuk; set => liczbaSztuk = value; }
        public string Magazyn { get => magazyn; set => magazyn = value; }


        public Produkt(string sym, string naz, int liczbaSztuk, string mag)
        {
            Symbol = sym;
            Nazwa = naz;
            LiczbaSztuk = liczbaSztuk;
            Magazyn = mag;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Symbol, Nazwa, LiczbaSztuk, Magazyn);
        }

    }
}
