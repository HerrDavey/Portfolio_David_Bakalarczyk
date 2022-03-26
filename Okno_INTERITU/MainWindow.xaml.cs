using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Okno_INTERITU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Wyjscie_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void oProgramie_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INFORMACJE O PROGRAMIE");
            sb.AppendLine();
            sb.AppendLine("Autor programu: David Bakalarczyk");
            sb.AppendLine("Cel powstania: Ułatwienie rozliczeń i organizacji członków gildii.");
            sb.AppendLine("Data powstania: 26.03.2022");
            sb.AppendLine("Wersja 0.0.1 PL");
            MessageBox.Show(sb.ToString());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            PanelSterowany.NavigationService.Navigate(new Home());
        }

        private void aktualnaListaGraczy_Click(object sender, RoutedEventArgs e)
        {
            PanelSterowany.NavigationService.Navigate(new aktualniCzlonkowie());
        }

        private void rozliczenie_Click(object sender, RoutedEventArgs e)
        {
            PanelSterowany.NavigationService.Navigate(new rozliczenieGraczy());
        }

        private void Archiwum_Click(object sender, RoutedEventArgs e)
        {
            PanelSterowany.NavigationService.Navigate(new Archiwum());
        }

        private void Informacje_Click(object sender, RoutedEventArgs e)
        {
            PanelSterowany.NavigationService.Navigate(new Informacje());
        }

        private void Rozbudowa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Praca nad funkcją w toku x_x Przepraszamy i życzymy cierpliwości!");
        }
    }
}
