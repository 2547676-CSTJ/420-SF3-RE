using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Worst_UI_UX
{
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        DispatcherTimer timer = new DispatcherTimer();
        bool couleur1 = true;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(400);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (couleur1)
                this.Background = Brushes.Lime;
            else
                this.Background = Brushes.Magenta;

            couleur1 = !couleur1;
        }

        
        private void btnCreer_MouseEnter(object sender, MouseEventArgs e)
        {
            Canvas.SetLeft(btnCreer, rnd.Next(0, 520));
            Canvas.SetTop(btnCreer, rnd.Next(0, 260));
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" dIre ok");
        }

        private void btnCreer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("es-tu certain ?");
            MessageBox.Show("vraiment vraiment certain ?");

            if (txtNom.Text == "")
            {
                MessageBox.Show("Erreur 7");
                ViderTout();
                return;
            }

            if (txtMotDePasse.Text.Length < 6)
            {
                MessageBox.Show("mauvais");
                ViderTout();
                return;
            }

            if (txtCourriel.Text != txtCourriel2.Text)
            {
                MessageBox.Show("les 2 courriels sont pas pareils (on te dit pas lequel est bon)");
                ViderTout();
                return;
            }

            if (chkConditions.IsChecked == false)
            {
                MessageBox.Show("Erreur 7");
                ViderTout();
                return;
            }

            MessageBox.Show("compte creer !!! ton mot de passe est : " + txtMotDePasse.Text);
            ViderTout();
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            ViderTout();
            MessageBox.Show("tout a ete efface");
        }

        private void ViderTout()
        {
            txtNom.Text = "";
            txtCourriel.Text = "";
            txtCourriel2.Text = "";
            txtMotDePasse.Text = "";
            chkConditions.IsChecked = false;
        }
    }
}