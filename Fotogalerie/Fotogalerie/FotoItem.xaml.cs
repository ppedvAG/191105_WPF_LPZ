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

namespace Fotogalerie
{
    /// <summary>
    /// Interaction logic for FotoItem.xaml
    /// </summary>
    public partial class FotoItem : UserControl // Wichtig: Ändern auf das, was im XAML als Root-Element definiert ist
    {
        public FotoItem()
        {
            InitializeComponent();
            this.DataContext = this;
        }



        public string ImageURL
        {
            get { return (string)GetValue(ImageURLProperty); }
            set { SetValue(ImageURLProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageURL.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageURLProperty =
            DependencyProperty.Register("ImageURL", typeof(string), typeof(FotoItem), new PropertyMetadata(null));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(FotoItem), new PropertyMetadata("_notitle_"));



    }
}
