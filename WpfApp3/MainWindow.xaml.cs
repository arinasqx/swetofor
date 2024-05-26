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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SetAllLightsGray()
        {
            btnRed.Background = Brushes.Gray;
            btnYellow.Background = Brushes.Gray;
            btnGreen.Background = Brushes.Gray;
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            SetAllLightsGray();
            btnRed.Background = Brushes.Red;
        }

        private void btnYellow_Click(object sender, RoutedEventArgs e)
        {
            SetAllLightsGray();
            btnYellow.Background = Brushes.Yellow;
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            SetAllLightsGray();
            btnGreen.Background = Brushes.Green;
        }
    }
}
