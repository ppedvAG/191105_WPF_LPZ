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

namespace HalloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Aufbau der Oberfläche
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBoxDemo.Text);
        }

        private void GrayGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Gray");
        }

        private void OrangeGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Orange");
        }

        private void HotPinkGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("HotPink");
        }

        private void RootGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Root-Grid");
        }
    }
}
