namespace Okno_INTERITU
{

    class Gracz
    {
        public string Nick { get; set; }
        public string klasaPostaci { get; set; }
        public string tytulGildyjny { get; set; }

        public Gracz() { }

        public Gracz(string nick, string klasapostaci, string tytulgildyjny)
        {
            Nick = nick;
            klasaPostaci = klasapostaci;
            tytulGildyjny = tytulgildyjny;
        }

        public override string ToString()
        {
            return $"{Nick} - {klasaPostaci} - {tytulGildyjny}";
        }


    }
}
