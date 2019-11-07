using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DBNavigatior_Pro
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            GetLocationCommand = new RelayCommand(GetLocation);
            GetJourneyDetailsCommand = new RelayCommand(GetJourneyDetails);
            GetDepartureBoardsForLocationCommand = new RelayCommand(GetDepartureBoardsFromLocation);

            service = new DBService();
        }

        private DBService service;

        private void GetDepartureBoardsFromLocation()
        {
            throw new NotImplementedException();
        }

        private void GetJourneyDetails()
        {
            throw new NotImplementedException();
        }

        private void GetLocation()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Elemente, die in der Oberfläche ausgewählt sind
        // -> TwoWayBinding !!! (mindestens: OneWayToSource)
        public string SearchString { get; set; }
        public Location CurrentLocation { get; set; }
        public DepartureBoard CurrentDepartureBoard { get; set; }

        public List<Location> Locations { get; set; }
        public List<DepartureBoard> DepartureBoards { get; set; }
        public List<JourneyDetails> JourneyDetails { get; set; }


        public ICommand GetLocationCommand { get; set; }
        public ICommand GetDepartureBoardsForLocationCommand { get; set; }
        public ICommand GetJourneyDetailsCommand { get; set; }
    }
}
