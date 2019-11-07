using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DBNavigator_Xamarin
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            GetLocationCommand = new Command(GetLocation);
            GetJourneyDetailsCommand = new Command(GetJourneyDetails);
            GetDepartureBoardsForLocationCommand = new Command(GetDepartureBoardsFromLocation);

            service = new DBService();
        }

        private DBService service;

        private void GetDepartureBoardsFromLocation()
        {
            DepartureBoards = service.GetDepartureBoardForLocation(CurrentLocation);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DepartureBoards)));
        }
        private void GetJourneyDetails()
        {
            JourneyDetails = service.GetJourneyDetails(CurrentDepartureBoard);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(JourneyDetails)));
        }
        private void GetLocation()
        {
            Locations = service.GetLocation(SearchString);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Locations)));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Elemente, die in der Oberfläche ausgewählt sind
        // -> TwoWayBinding !!! (mindestens: OneWayToSource)
        public string SearchString { get; set; }

        private Location currentLocation;
        public Location CurrentLocation
        {
            get => currentLocation;
            set
            {
                currentLocation = value;
                if (value != null)
                {
                    GetDepartureBoardsFromLocation();
                }
            }
        }

        public ArrivalBoard CurrentDepartureBoard { get; set; }

        public List<Location> Locations { get; set; }
        public List<ArrivalBoard> DepartureBoards { get; set; }
        public List<JourneyDetails> JourneyDetails { get; set; }


        public Command GetLocationCommand { get; set; }
        public Command GetDepartureBoardsForLocationCommand { get; set; }
        public Command GetJourneyDetailsCommand { get; set; }
    }
}
