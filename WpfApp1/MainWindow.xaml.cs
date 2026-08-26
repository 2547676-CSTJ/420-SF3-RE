using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


// Ici on met le code derriere/behind 
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnAction1.Click += AfficherMessage1;
            btnAction2.Click += AfficherMessage2;
            btnAction3.Click += AfficherMessage3;
        }

        private void AfficherMessage1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
        private void AfficherMessage2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
        private void AfficherMessage3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}