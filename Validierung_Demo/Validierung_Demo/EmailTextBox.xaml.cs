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
    /// Interaction logic for EmailTextBox.xaml
    /// </summary>
    public partial class EmailTextBox : UserControl
    {
        public EmailTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }



        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(EmailTextBox), new PropertyMetadata(string.Empty));


    }
}
