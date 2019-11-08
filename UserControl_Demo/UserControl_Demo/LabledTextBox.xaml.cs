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

namespace UserControl_Demo
{
    /// <summary>
    /// Interaction logic for LabledTextBox.xaml
    /// </summary>
    public partial class LabledTextBox : UserControl
    {
        public LabledTextBox()
        {
            InitializeComponent();
            this.DataContext = this; // Neue Standarddatenquelle für Bindings bin ich selbst ;)
        }

        //public string LabelText { get; set; }
        //public string TextBoxText { get; set; }

        // DependencyProperties:

        // propdp + TAB + TAB



        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(LabledTextBox), new PropertyMetadata(""));




        public string TextBoxText
        {
            get { return (string)GetValue(TextBoxTextProperty); }
            set { SetValue(TextBoxTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxTextProperty =
            DependencyProperty.Register("TextBoxText", typeof(string), typeof(LabledTextBox), new PropertyMetadata(""));

    }
}
