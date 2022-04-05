using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace liczbaSztukProdukt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "Tablica matematyczna", 0, "M2 - Kraków", "Tablica kredowa o wymiarach 900x400."));
            ListaProduktow.Add(new Produkt("DL-03", "Długopis żelowy", 5700, "M1 - Kraków", "Długopis standardowy do wykorzystania biurowego."));
            ListaProduktow.Add(new Produkt("OL-01", "Ołówek zwykły", 4788, "M1 - Kraków", "Ołowek z gumką do mazania."));
            ListaProduktow.Add(new Produkt("SZ-02", "Szpilka tablicowa", 9660, "M2 - Kraków", "Tablica korkowa o wymiarach 500x300"));
            gridProdukty.ItemsSource = ListaProduktow;

        }




    }
}
