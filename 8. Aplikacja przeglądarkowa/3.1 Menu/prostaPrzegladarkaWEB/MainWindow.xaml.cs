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
using System.Reflection;

namespace prostaPrzegladarkaWEB
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

        // Metody obsługi MENU
        private void RamkaOn_Click(object sender, RoutedEventArgs e)
        {
            if (brdRamka != null)
            {
                brdRamka.BorderThickness = new Thickness(3);
            }
        }

        private void RamkaOff_Click(object sender, RoutedEventArgs e)
        {
            if (brdRamka != null)
            {
                brdRamka.BorderThickness = new Thickness(0);
            }
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Filter = "WebPage|*.html";
            dialog.DefaultExt = ".html";
            dynamic doc = wbPrzegladarka.Document;
            
            if (doc != null)
            {
                var htmlText = doc.documentElement.InnerHtml;
                if(dialog.ShowDialog() == true && htmlText != null)
                {
                    File.WriteAllText(dialog.FileName, htmlText);
                }
            }
        }

        private void Tmp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opcja w budowie");
        }

        private void OProgramie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Prosta przeglądarka www, Wersja 0.0.1, Twórca: David Bakalarczyk na podstawie książki \"Wprowadzenie do WPF'a\".");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // Koniec metod menu

        //Metody do przycisków w przeglądarce
        private void btnWejdz_Click(object sender, RoutedEventArgs e)
        {
            if (txtAdres.Text != null)
                wbPrzegladarka.Navigate(txtAdres.Text);
            else
                MessageBox.Show("Brak szukanej frazy");
        }

        private void btnWstecz_Click(object sender, RoutedEventArgs e)
        {
            if (wbPrzegladarka.CanGoBack)
                wbPrzegladarka.GoBack();
        }

        private void btnDalej_Click(object sender, RoutedEventArgs e)
        {
            if (wbPrzegladarka.CanGoForward)
                wbPrzegladarka.GoForward();
        }

        private void txtAdres_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                wbPrzegladarka.Navigate(txtAdres.Text);
        }
        // Koniec metod przycisków przeglądarki

        //Metody dla przeglądarki WWW
        private void wbPrzegladarka_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            txtAdres.Text = e.Uri.OriginalString;
        }

        private void HideScriptErrors(WebBrowser wb, bool Hide)
        {
            // Ukrycie błędów JavaScript z biblioteki MSDN
            dynamic activeX = this.wbPrzegladarka.GetType().InvokeMember("ActiveXInstance",
                BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, this.wbPrzegladarka, new object[] { });
            activeX.Silent = true;
        }

        private void wbPrzegladarka_Navigated(object sender, NavigationEventArgs e)
        {
            HideScriptErrors(wbPrzegladarka, true);
        }





    }








}
