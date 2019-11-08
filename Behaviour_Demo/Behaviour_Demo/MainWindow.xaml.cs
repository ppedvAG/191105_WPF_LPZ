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
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Behaviour_Demo
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

        private NumberTextboxBehavior beh = new NumberTextboxBehavior();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Behavior zur Laufzeit ein/ausschalten
            var allBehaviours = Interaction.GetBehaviors(textBoxBehaviour);
            if (allBehaviours.Contains(beh))
                allBehaviours.Remove(beh);
            else
                allBehaviours.Add(beh);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DetailsWindow w = new DetailsWindow();

            // w.Show();

            this.Visibility = Visibility.Hidden;
            w.ShowDialog();
            this.Visibility = Visibility.Visible;

        }
    }
}
