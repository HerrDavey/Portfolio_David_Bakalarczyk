using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Okno_INTERITU
{
    /// <summary>
    /// Interaction logic for DodajGracza.xaml
    /// </summary>
    public partial class DodajGracza : Window
    {
        private aktualniCzlonkowie aktualniCzlonkowie = null;
        private bool czyNowyGraczy = true;
        private Gracz nowyGracz;

        public DodajGracza(aktualniCzlonkowie aktualniCzlo, bool czyNowy=false)
        {
            InitializeComponent();
            aktualniCzlonkowie = aktualniCzlo;
            czyNowyGraczy = czyNowy;
            WiazanieDanych();
        }

        //Łączenie edycji i dodawania graczy
        private void WiazanieDanych()
        {
            //Edycja
            Gracz graczZListy = aktualniCzlonkowie.lstGraczy_aktualnych.SelectedItem as Gracz;
            if (graczZListy != null)
                gridDodawanieGracza.DataContext = graczZListy;

            //Dodawanie nowgo gracza
            if(czyNowyGraczy == true)
            {
                nowyGracz = new Gracz("", "", "");
                gridDodawanieGracza.DataContext = nowyGracz;
            }
        }

        private void btn_PotwierdzNowego_Click(object sender, RoutedEventArgs e)
        {
            if (czyNowyGraczy == true)
                aktualniCzlonkowie.ListaGraczy.Add(nowyGracz);
            this.Close();
        }




    }
}
