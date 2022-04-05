using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczbaSztukProdukt
{
    class Produkt
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }
        public string Opis { get; set; }

        public Produkt(string symbol, string nazwa, int liczbaSztuk, string magazyn, string opis)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            LiczbaSztuk = liczbaSztuk;
            Magazyn = magazyn;
            Opis = opis;
        }

        public Produkt() { }
    }
}
