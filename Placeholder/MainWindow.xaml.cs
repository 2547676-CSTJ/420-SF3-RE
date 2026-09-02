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

namespace Placeholder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string placeholderMessage = "votre@courriel.com";

        public MainWindow()
        {
            InitializeComponent();

            tBoxCourriel.Text = placeholderMessage;
            tBoxCourriel.Foreground = Brushes.Gray;

            tBoxCourriel.TextChanged += ChangerText;
            tBoxCourriel.GotFocus += TBoxCourriel_GotFocus;

        }

        private void TBoxCourriel_GotFocus(object sender, TextChangedEventArgs e)
        {
            TBoxCourriel.Clear();
        }
        private void ChagerText(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(tBoxCourriel.Text))
            {
                tBoxCourriel.Text = placeholderMessage;
            }
        }
       


    }
}