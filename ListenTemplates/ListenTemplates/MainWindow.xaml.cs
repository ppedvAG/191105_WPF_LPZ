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

namespace ListenTemplates
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

        private void buttonEinfügen_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            var wert = r.Next(0, 3);

            Person p1 = null;
            if (wert == 1)
            {
                p1 = new Person
                {
                    Vorname = "Tom",
                    Nachname = "Ate",
                    Alter = 10,
                    Kontostand = 100,
                    ImageURL = "http://ais.bz-ticket.de/piece/09/4a/b8/7a/155891834-f-3_2-w-980.jpg"
                };
            }
            else if (wert == 2)
            {
                p1 = new Mitarbeiter
                {
                    MitarbeiterID = 12,
                    Vorname = "Anna",
                    Nachname = "Nass",
                    Alter = 20,
                    Kontostand = 200,
                    ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81mzRlPT4gL._SY445_.jpg"
                };
            }
            else
            {
                p1 = new Kunde
                {
                    Stammkunde = true,
                    Vorname = "Peter",
                    Nachname = "Silie",
                    Alter = 30,
                    Kontostand = 3000,
                    ImageURL = "https://www.ndr.de/ratgeber/kochen/warenkunde/petersilie109_v-contentxl.jpg"
                };
            }

            listBoxPersonen.Items.Add(p1);
        }
    }
}
