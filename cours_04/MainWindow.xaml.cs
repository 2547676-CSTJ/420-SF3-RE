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

namespace cours_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char Sexe { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            btnValiderSexe.click += ValiderSexe;
            Sexe = Sexe.None;
        }

        private void ValiderSexe(object sender, RoutedEventArgs e)
        {
            char sexe = ' ';

            // == true oblige,car IsChecek retourne un bool? (nullable)
            // ce nest donc plus binaire, on  a 3 choix: true, false, null
            if(rbtMale.IsChecked == true)
            {
                sexe = Sexe.Male;
            }
            else if (rbtFemale.IsChecked == true)
            {
                sexe = Sexe.Female;
            }
            else if (rbtnOther.IsChecked == true)
            {
                sexe = Sexe.Other;
            }
        
        }
    }
}