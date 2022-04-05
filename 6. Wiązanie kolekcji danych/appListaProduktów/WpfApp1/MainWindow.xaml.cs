using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Produkt> ListaProduktów = null;
        private Produkt p1 = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();

           
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktów = new ObservableCollection<Produkt>();
            ListaProduktów.Add(new Produkt("01-11", "Tablica matematyczna", 240, "M2 - Kraków"));
            ListaProduktów.Add(new Produkt("DL-03", "Długopis żelowy", 5700, "M1 - Kraków"));
            ListaProduktów.Add(new Produkt("OL-01", "Ołówek zwykły", 4788, "M1 - Kraków"));
            ListaProduktów.Add(new Produkt("SZ-02", "Szpilka tablicowa", 9660, "M2 - Kraków"));
            lstProdukty.ItemsSource = ListaProduktów;

            //Sortowanie listView po przypisaniu
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

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource).Refresh();
        }

        private void lstProdukty_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window1 okno1 = new Window1(this); 
            okno1.ShowDialog();
        }

        private void btnUsun_Click(object sender, RoutedEventArgs e)
        {
            Produkt produktZListy = lstProdukty.SelectedItem as Produkt;
            MessageBoxResult odpowiedz = MessageBox.Show("Czy wykasować produkt: " + produktZListy.ToString() + "?", "Pytanie", MessageBoxButton.YesNo, 
                MessageBoxImage.Question);
            if (odpowiedz == MessageBoxResult.Yes)
                ListaProduktów.Remove(produktZListy);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno1 = new Window1(this, true);
            okno1.ShowDialog();
        }
    }
}
