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

namespace Validierung_Demo
{
    /// <summary>
    /// Interaction logic for AgeTextBox.xaml
    /// </summary>
    public partial class AgeTextBox : UserControl
    {
        public AgeTextBox()
        {
            InitializeComponent();
            this.DataContext = this;

            // Beim erstellen des Elements werden diese Werte gesetzt
            CurrentValidation.Minimum = Minimum;
            CurrentValidation.Maximum = Maximum;
        }



        public string Alter
        {
            get { return (string)GetValue(AlterProperty); }
            set { SetValue(AlterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Alter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AlterProperty =
            DependencyProperty.Register("Alter", typeof(string), typeof(AgeTextBox), new PropertyMetadata("0"));



        private int minimum;
        public int Minimum
        {
            get => minimum;
            set 
            {
                minimum = value;
                CurrentValidation.Minimum = Minimum;
            }
        }

        private int maximum;
        public int Maximum
        {
            get => maximum;
            set 
            {
                maximum = value;
                CurrentValidation.Maximum = Maximum;
            }
        }

    }
}
