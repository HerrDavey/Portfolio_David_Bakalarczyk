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
using System.IO;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace DataGridWithXML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string plik1 = @"C:\Users\dawid\Desktop\C#\Nauka własna\Wprowadzenie do XAML\Wprowadzenie do XAML\VII. DataGrid\Rodział 7.4\DataGridWithXML\dane\Produkty.xml";
        private string plik2 = @"C:\Users\dawid\Desktop\C#\Nauka własna\Wprowadzenie do XAML\Wprowadzenie do XAML\VII. DataGrid\Rodział 7.4\DataGridWithXML\dane\Produkty2.xml";
        private XElement wykazProduktow;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            if (File.Exists(plik1))
                wykazProduktow = XElement.Load(plik1);
            gridProdukty.DataContext = wykazProduktow;
            
            ObservableCollection<string> ListaMagazynow = new ObservableCollection<string>()
            {"M1 - Kraków", "M2 - Kraków", "M3 - Katowice"};
            nazwaMagazynu.ItemsSource = ListaMagazynow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wykazProduktow.Save(plik2);
            MessageBox.Show("Pomyślnie zapisano dane do pliku");
        }
    }
}
