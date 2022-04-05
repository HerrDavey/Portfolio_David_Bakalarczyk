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
using System.ComponentModel;

namespace produktJednookienny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Produkt> ListaProduktow = null;
        private Produkt nowyProdukt;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "Tablica matematyczna", 240, "M2 - Kraków"));
            ListaProduktow.Add(new Produkt("DL-03", "Długopis żelowy", 5700, "M1 - Kraków"));
            ListaProduktow.Add(new Produkt("OL-01", "Ołówek zwykły", 4788, "M1 - Kraków"));
            ListaProduktow.Add(new Produkt("SZ-02", "Szpilka tablicowa", 9660, "M2 - Kraków"));
            lstProdukty.ItemsSource = ListaProduktow;

            //Sortowanie po produkcie
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource);
            widok.SortDescriptions.Add(new SortDescription("Magazyn", ListSortDirection.Ascending));
            widok.SortDescriptions.Add(new SortDescription("Nazwa", ListSortDirection.Ascending));
            widok.Filter = FiltrUzytkownika;
        }

        private bool FiltrUzytkownika(object item)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Produkt).Nazwa.IndexOf(txtFilter.Text, System.StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource).Refresh();
        }

        private void btnUsun_Click(object sender, RoutedEventArgs e)
        {
            Produkt produktZListy = lstProdukty.SelectedItem as Produkt;
            MessageBoxResult odpowiedz = MessageBox.Show("Czy wykasować produkt: " + produktZListy.ToString() + "?", "Pytanie", MessageBoxButton.YesNo, 
                MessageBoxImage.Question);
            if (odpowiedz == MessageBoxResult.Yes)
                ListaProduktow.Remove(produktZListy);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            nowyProdukt = new Produkt("AA-00", "", 0, "");
            ListaProduktow.Add(nowyProdukt);
        }
    }
}
