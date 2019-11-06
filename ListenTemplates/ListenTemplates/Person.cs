using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenTemplates
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }

        public string ImageURL { get; set; }
    }

    class Mitarbeiter : Person
    {
        public int MitarbeiterID { get; set; }
    }

    class Kunde : Person
    {
        public bool Stammkunde { get; set; }
    }
}
