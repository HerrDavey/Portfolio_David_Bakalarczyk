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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        string sciezka = "pack://application:,,,/rysunki/";

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "Tablica matematyczna", 240, "M2 - Kraków", new Uri(sciezka + "tablica_matematycznq.jpg"), "Tablica kredowa o wymiarach 900x400."));
            ListaProduktow.Add(new Produkt("DL-03", "Długopis żelowy", 5700, "M1 - Kraków", new Uri(sciezka + "dlugopis_zelowy.jpg"), "Długopis standardowy do wykorzystania biurowego."));
            ListaProduktow.Add(new Produkt("OL-01", "Ołówek zwykły", 4788, "M1 - Kraków", new Uri(sciezka + "olowek_zwykly.jpg"), "Ołowek z gumką do mazania."));
            ListaProduktow.Add(new Produkt("SZ-02", "Szpilka tablicowa", 9660, "M2 - Kraków", new Uri(sciezka + "tablica_szpilkowa.jpg"), "Tablica korkowa o wymiarach 500x300"));
            gridProdukty.ItemsSource = ListaProduktow;

            ObservableCollection<string> ListaMagazynow = new ObservableCollection<string>()
            {"M1 - Kraków", "M2 - Kraków"};
            nazwaMagazynu.ItemsSource = ListaMagazynow;

            ICollectionView widok = CollectionViewSource.GetDefaultView(gridProdukty.ItemsSource);
            widok.GroupDescriptions.Add(new PropertyGroupDescription("Magazyn"));
        }

        private void btnZdjecie_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Wybierz zdjęcie";
            dialog.Filter = "Image files (*.jpg, *.png; *.jpeg)|*.jpg;*.png;*.jpeg;|Allfiles(*.*)|*.*";
            dialog.InitialDirectory = @"C:\temp\";
            
            if(dialog.ShowDialog() == true)
            {
                (gridProdukty.SelectedItem as Produkt).Zdjecie = new Uri(dialog.FileName);
                gridProdukty.CommitEdit(DataGridEditingUnit.Cell, true);
                gridProdukty.CommitEdit();
                CollectionViewSource.GetDefaultView(gridProdukty.ItemsSource).Refresh();

            }
        }




    }
}
