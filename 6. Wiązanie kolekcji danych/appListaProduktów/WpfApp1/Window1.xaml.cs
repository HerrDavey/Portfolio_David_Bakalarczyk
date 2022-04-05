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
using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        private MainWindow mainWindow = null;
        private bool czyNowyProdukt = true;
        private Produkt nowyProdukt;

        public Window1()
        {
            InitializeComponent();
        }

        public Window1(MainWindow manWin, bool czyNowy = false)
        {
            InitializeComponent();
            mainWindow = manWin;
            czyNowyProdukt = czyNowy;
            PrzygotujWiazanie();
        }


        private void PrzygotujWiazanie()
        {
            Produkt produktZListy = mainWindow.lstProdukty.SelectedItem as Produkt;
            if(produktZListy != null)
            {
                gridProdukt.DataContext = produktZListy;         
            }

            if (czyNowyProdukt == true)
            {
                nowyProdukt = new Produkt("AA-00", "", 0, "");
                gridProdukt.DataContext = nowyProdukt;
            }
        }

        private void btnPotwierdz_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ListaProduktów.Add(nowyProdukt);
            this.Close();
        }





    }
}
