using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Simpel.Model
{
    public class PersonenService
    {
        public List<Person> GetPersonen()
        {
            // ToDo: Daten aus dem Internet laden (REST-Service ansteuern, WCF)...

            return new List<Person>
            {
                new Person{ImageURL="https://placekitten.com/g/100/100",Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{ImageURL="http://placebacon.com/100/100",Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000},
                new Person{ImageURL="https://www.placecage.com/g/100/100",Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=300},
                new Person{ImageURL="https://www.stevensegallery.com/100/100",Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-400},
                new Person{ImageURL="http://www.fillmurray.com/100/100",Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=55500},
                new Person{ImageURL="https://placekitten.com/g/100/100",Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=5666600},
                new Person{ImageURL="http://placebacon.com/100/100",Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-7777},
                new Person{ImageURL="https://www.placecage.com/g/100/100",Vorname="Albert",Nachname="Tross",Alter=80,Kontostand=87654},
                new Person{ImageURL="https://www.stevensegallery.com/100/100",Vorname="Kroko",Nachname="Dil",Alter=90,Kontostand=987},
                new Person{ImageURL="http://www.fillmurray.com/100/100",Vorname="Anna",Nachname="Bolika",Alter=100,Kontostand=100000000}
            };
        }
    }
}
