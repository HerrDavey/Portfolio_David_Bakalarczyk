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

namespace Wyplata
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
        private void btnTak_MouseEnter(object sender, MouseEventArgs e)
        {
            var tmpMargin = btnTak.Margin;
            btnTak.Margin = btnNie.Margin;
            btnNie.Margin = tmpMargin;
        }

        private void btnTak_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTak.Content = "Tak";
        }
    }
}
