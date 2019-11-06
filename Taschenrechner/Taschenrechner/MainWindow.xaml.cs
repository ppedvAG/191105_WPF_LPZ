using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Taschenrechner
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

        private void labelClose_Click(object sender, MouseButtonEventArgs e)
        {
            // Hinweis: Mausklick wird sowohl von "MoveWindow" als auch von dem Label erkannt
            // -> Ziel: Anstelle von "Verschieben" soll geschlossen werden -> Bubbling/Tunneling

            // Schließen einer WPF-Anwendung
            Close();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            if(e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ChangeStyle(object sender)
        {
            // this.Resources; // <-- <Window.Resources>
            // Application.Current.Resources // app.xaml - Ressourcen

            Random r = new Random();
            int wert = r.Next(0, 3);
            Button auslöser = (Button)sender;

            if (wert == 0)
                auslöser.Style = (Style)Resources["ButtonStyleChristos"];
            else if (wert == 1)
                auslöser.Style = (Style)Resources["ButtonStyleOliver"];
            else
                auslöser.Style = (Style)Resources["ButtonStyleJohannes"];
        }

        private void buttonAddieren_Click(object sender, RoutedEventArgs e)
        {
            // float und double: Zahlen auf Basis 2
            // decimal: Zahlen auf Basis 10  ---> Faktor 50 langsamer

            // Genaue Angabe des Styles :
            //decimal demo = decimal.Parse("123.123,132321322", NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);

            decimal zahl1 = Convert.ToDecimal(textBoxZahl1.Text,Thread.CurrentThread.CurrentCulture); // de-AT
            decimal zahl2 = Convert.ToDecimal(textBoxZahl2.Text,Thread.CurrentThread.CurrentCulture); // de-AT

            labelErgebnis.Content = zahl1 + zahl2;
            ChangeStyle(sender);
        }

        private void buttonSubtrahieren_Click(object sender, RoutedEventArgs e)
        {
            decimal zahl1 = Convert.ToDecimal(textBoxZahl1.Text, Thread.CurrentThread.CurrentCulture); // de-AT
            decimal zahl2 = Convert.ToDecimal(textBoxZahl2.Text, Thread.CurrentThread.CurrentCulture); // de-AT

            labelErgebnis.Content = zahl1 - zahl2;
            ChangeStyle(sender);
        }

        private void buttonMultiplizieren_Click(object sender, RoutedEventArgs e)
        {
            decimal zahl1 = Convert.ToDecimal(textBoxZahl1.Text, Thread.CurrentThread.CurrentCulture); // de-AT
            decimal zahl2 = Convert.ToDecimal(textBoxZahl2.Text, Thread.CurrentThread.CurrentCulture); // de-AT

            labelErgebnis.Content = zahl1 * zahl2;
            ChangeStyle(sender);
        }

        private void buttonDividieren_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxZahl2.Text == "0")
            {
                labelErgebnis.Content = "Division durch Null !!!!";
                return;
            }

            decimal zahl1 = Convert.ToDecimal(textBoxZahl1.Text, Thread.CurrentThread.CurrentCulture); // de-AT
            decimal zahl2 = Convert.ToDecimal(textBoxZahl2.Text, Thread.CurrentThread.CurrentCulture); // de-AT

            labelErgebnis.Content = zahl1 / zahl2;
            ChangeStyle(sender);
        }
    }
}
