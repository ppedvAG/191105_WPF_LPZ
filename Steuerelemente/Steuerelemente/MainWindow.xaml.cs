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

namespace Steuerelemente
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(comboBoxFrucht.Text +  sliderWert.Value);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddElement(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            var wert = r.Next(0, 3);
            if(wert == 1)
                listBoxIrgendwas.Items.Add("Hallo Welt");
            else if (wert == 2)
                listBoxIrgendwas.Items.Add(12);
            else
                listBoxIrgendwas.Items.Add(new Button { Content = "Button" });
        }
    }
}
