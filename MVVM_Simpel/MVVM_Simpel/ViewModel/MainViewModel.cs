using MVVM_Simpel.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Simpel.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            GetPersonenCommand = new ButtonCommand(GetPersonen);
        }

        private void GetPersonen()
        {
            Personenliste = service.GetPersonen();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Personenliste)));
        }

        // Alle Services:
        private PersonenService service = new PersonenService();

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Person> Personenliste { get; set; }
        public ICommand GetPersonenCommand { get; set; }
    }
}
