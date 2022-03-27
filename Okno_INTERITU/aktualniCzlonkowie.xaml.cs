using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Okno_INTERITU
{
    /// <summary>
    /// Interaction logic for aktualniCzlonkowie.xaml
    /// </summary>
    public partial class aktualniCzlonkowie : Page
    {
        internal ObservableCollection<Gracz> ListaGraczy = null;

        public aktualniCzlonkowie()
        {
            InitializeComponent();
            WiazanieDanych();
        }

        private void WiazanieDanych()
        {
            //Stworzenie listy graczy i ich wyświetlenie
            ListaGraczy = new ObservableCollection<Gracz>();
            ListaGraczy.Add(new Gracz("wwiedzminn4", "Mag", "Mistrz Gildii"));
            ListaGraczy.Add(new Gracz("janek7777", "Wojownik", "Zastępca Mistrza Gildii"));
            ListaGraczy.Add(new Gracz("HRS", "Mag", "Zastępca Mistrza Gildii"));

            lstGraczy_aktualnych.ItemsSource = ListaGraczy;

            //Sortowanie po tytule gildyjnym
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstGraczy_aktualnych.ItemsSource);
            widok.SortDescriptions.Add(new SortDescription("tytulGildyjny", ListSortDirection.Ascending));
            widok.Filter = FiltrUzytkowynika;

        }


        //Metody do filtrowania danych po nicku gracza:
        // - Filtr wg Nicku
        private bool FiltrUzytkowynika(object item)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Gracz).Nick.IndexOf(txtFilter.Text, System.StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // - odwołanie do listy w WPF'ie i odświeżanie w czasie rzeczywistym
        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lstGraczy_aktualnych.ItemsSource).Refresh();
        }

        // Dodawanie nowego gracza
        private void lstGraczy_aktualnych_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DodajGracza dodajGracza1 = new DodajGracza(this);
            dodajGracza1.Show();
        }
        // -||-
        private void btnDodaj_Gracza_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DodajGracza dodajGracza = new DodajGracza(this, true);
            dodajGracza.ShowDialog();
        }

        // Usuwanie gracza z zapytaniem czy na pewno
        private void btnUsun_Gracza_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Gracz graczZListy = lstGraczy_aktualnych.SelectedItem as Gracz;
            MessageBoxResult odpowiedz = MessageBox.Show("Czy usunąć z listy gracza: " + graczZListy.ToString() + "?", "Pytanie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (odpowiedz == MessageBoxResult.Yes)
                ListaGraczy.Remove(graczZListy);
        }
    }
}
