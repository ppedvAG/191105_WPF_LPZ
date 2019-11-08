using System;
using System.Collections.Generic;
using Fotogalerie.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Fotogalerie.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            service = new FotoService();
            GetFotosCommand = new RelayCommand(GetFotos); //  <-- Bereits in MVVMLight eingebaut
        }

        private FotoService service;

        public RelayCommand GetFotosCommand { get; set; }
        public List<Foto> Fotos { get; set; }
        private void GetFotos()
        {
            Fotos = service.GetFotos();
            RaisePropertyChanged(nameof(Fotos)); // <-- Bereits in MVVMLight eingebaut
        }
    }
}